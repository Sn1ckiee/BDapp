using BDapp.Models;
using BDapp.Views;
using BDapp._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDapp.Presenters
{
    public class ResearchPresenter
    {
        //Fields
        private IResearchView view;
        private IResearchRepository repository;
        private BindingSource researchesBindingSource;
        private IEnumerable<ResearchModel> researchList;
        //Constructor
        public ResearchPresenter(IResearchView view, IResearchRepository repository)
        {
            this.researchesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchResearch;
            this.view.AddNewEvent += AddNewResearch;
            this.view.EditEvent += LoadSelectedResearchToEdit;
            this.view.DeleteEvent += DeleteSelectedResearch;
            this.view.SaveEvent += SaveResearch;
            this.view.CancelEvent += CancelAction;
            //Set wells bindind source
            this.view.SetResearchListBindingSource(researchesBindingSource);
            //Load well list view
            LoadAllResearchList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void LoadAllResearchList()
        {
            researchList = repository.GetAll();
            researchesBindingSource.DataSource = researchList;//Set data source.
        }
        private void SearchResearch(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                researchList = repository.GetByValue(this.view.SearchValue);
            else researchList = repository.GetAll();
            researchesBindingSource.DataSource = researchList;
        }
        private void AddNewResearch(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedResearchToEdit(object sender, EventArgs e)
        {
            var research = (ResearchModel)researchesBindingSource.Current;
            view.ResearchId = research.Id.ToString();
            view.Data = research.Data.ToString();
            view.Method = research.Method;
            view.IsEdit = true;
        }
        private void SaveResearch(object sender, EventArgs e)
        {
            var model = new ResearchModel();
            model.Id = Convert.ToInt32(view.ResearchId);
            model.Data = Convert.ToInt32(view.Data);
            model.Method = view.Method;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Исследовние успешно отредактировано";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Исследовние успешно добавлено";
                }
                view.IsSuccessful = true;
                LoadAllResearchList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanviewFields()
        {
            view.ResearchId = "0";
            view.Data = "";
            view.Method = "";

        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedResearch(object sender, EventArgs e)
        {
            try
            {
                var research = (ResearchModel)researchesBindingSource.Current;
                repository.Delete(research.Id);
                view.IsSuccessful = true;
                view.Message = "Исследование успешно удалено";
                LoadAllResearchList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Произошла ошибка, не удалось правильно удалить исследование";
            }
        }
    }
}
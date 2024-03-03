    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using BDapp.Models;
    using BDapp.Views;
    using BDapp._Repositories;
   
    namespace BDapp.Presenters
    {
        public class WellPresenter
        {
            //Fields
            private IWellView view;
            private IWellRepository repository;
            private BindingSource wellsBindingSource;
            private IEnumerable<WellModel> wellList;
            //Constructor
            public WellPresenter(IWellView view, IWellRepository repository)
            {
                this.wellsBindingSource = new BindingSource();
                this.view = view;
                this.repository = repository;
                //Subscribe event handler methods to view events
                this.view.SearchEvent += SearchWell;
                this.view.AddNewEvent += AddNewWell;
                this.view.EditEvent += LoadSelectedWellToEdit;
                this.view.DeleteEvent += DeleteSelectedWell;
                this.view.SaveEvent += SaveWell;
                this.view.CancelEvent += CancelAction;
                //Set wells bindind source
                this.view.SetWellListBindingSource(wellsBindingSource);
                //Load well list view
                LoadAllWellList();
                //Show view
                this.view.Show();
            }
        //Methods
        private void LoadAllWellList()
        {
            wellList = repository.GetAll();
            wellsBindingSource.DataSource = wellList;//Set data source.
        }
        private void SearchWell(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                wellList = repository.GetByValue(this.view.SearchValue);
            else wellList = repository.GetAll();
            wellsBindingSource.DataSource = wellList;
        }
        private void AddNewWell(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedWellToEdit(object sender, EventArgs e)
        {
            var well = (WellModel)wellsBindingSource.Current;
            view.WellId = well.Id.ToString();
            view.Number = well.Number.ToString();
            view.Area = well.Area;
            view.Cluster = well.Cluster;
            view.InstrumentType = well.InstrumentType; 
            view.HicenseHolder = well.HicenseHolder; 
            view.User = well.User; ;
            view.Customer = well.Customer; 
            view.Contractor = well.Contractor; 
            view.BatchOperator = well.BatchOperator; 
            view.FilesLocation = well.FilesLocation; 
            view.AdditionalInfo = well.AdditionalInfo; 
            view.IsEdit = true;
        }
        private void SaveWell(object sender, EventArgs e)
        {
            var model = new WellModel();
            model.Id = Convert.ToInt32(view.WellId);
            model.Number = Convert.ToInt32(view.Number);
            model.Area = view.Area;
            model.Cluster = view.Cluster;
            model.InstrumentType = view.InstrumentType;
            model.HicenseHolder = view.HicenseHolder;
            model.User = view.User;
            model.Customer = view.Customer;
            model.Contractor = view.Contractor;
            model.BatchOperator = view.BatchOperator;
            model.FilesLocation = view.FilesLocation;
            model.AdditionalInfo = view.AdditionalInfo;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Скважина успешно отредактирована";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Скважина успешно добавлена";
                }
                view.IsSuccessful = true;
                LoadAllWellList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.WellId = "0";
            view.Number = "";
            view.Area = "";
            view.Cluster = "";
            view.InstrumentType = "";
            view.HicenseHolder = "";
            view.User = "";
            view.Customer = "";
            view.Contractor = "";
            view.BatchOperator = "";
            view.FilesLocation = "";
            view.AdditionalInfo = "";

        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedWell(object sender, EventArgs e)
        {
            try
            {
                var well = (WellModel)wellsBindingSource.Current;
                repository.Delete(well.Id);
                view.IsSuccessful = true;
                view.Message = "Скважина успешно удалена";
                LoadAllWellList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Произошла ошибка, не удалось правильно удалить скважину";
            }
        }
    }
}
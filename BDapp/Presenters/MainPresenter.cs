using BDapp.Views;
using BDapp.Models;
using BDapp._Repositories;
using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BDapp.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqliteConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqliteConnectionString = sqlConnectionString;
            this.mainView.ShowWellView += ShowWellsView;
            this.mainView.ShowResearchView += ShowResearchesView;
        }
        private void ShowWellsView(object sender, EventArgs e)
        {
            IWellView view = WellView.GetInstance((MainView)mainView);
            IWellRepository repository = new WellRepository(sqliteConnectionString);
            new WellPresenter(view, repository);
        }
        private void ShowResearchesView(object sender, EventArgs e)
        {
            IResearchView view = ResearchView.GetInstance((MainView)mainView);
            IResearchRepository repository = new ResearchRepository(sqliteConnectionString);
            new ResearchPresenter(view, repository);
        }

    }
}
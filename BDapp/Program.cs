using BDapp.Presenters;
using BDapp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;

namespace BDapp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqliteConnectionString = "Data Source=mydatabase.db;Version=3;";
            IMainView view = new MainView();
            new MainPresenter(view, sqliteConnectionString);
            Application.Run((Form)view);
        }
    }
}

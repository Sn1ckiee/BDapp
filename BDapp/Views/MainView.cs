using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDapp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnWells.Click += delegate { ShowWellView?.Invoke(this, EventArgs.Empty); };
            btnResearch.Click += delegate { ShowResearchView?.Invoke(this, EventArgs.Empty); };

        }      
        public event EventHandler ShowWellView;
        public event EventHandler ShowResearchView;
    }
}
using BDapp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace BDapp.Views
{
    public partial class WellView : Form, IWellView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        //Constructor
        public WellView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageWellDetail);
            btnClose.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Others
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageWellList);
                tabControl1.TabPages.Add(tabPageWellDetail);
                tabPageWellDetail.Text = "Добавить скважину";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageWellList);
                tabControl1.TabPages.Add(tabPageWellDetail);
                tabPageWellDetail.Text = "Редактировать скважину";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageWellDetail);
                    tabControl1.TabPages.Add(tabPageWellList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageWellDetail);
                tabControl1.TabPages.Add(tabPageWellList);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены что хотите удалить выбранную скважину?", "Предупреждение",
 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //Properties
        public string WellId
        {
            get { return txtWellId.Text; }
            set { txtWellId.Text = value; }
        }
        public string Number
        {
            get { return txtNumber.Text; }
            set { txtNumber.Text = value; }
        }
        public string Area
        {
            get { return txtArea.Text; }
            set { txtArea.Text = value; }
        }
        public string Cluster
        {
            get { return txtCluster.Text; }
            set { txtCluster.Text = value; }
        }
        public string InstrumentType
        {
            get { return txtInstrumentType.Text; }
            set { txtInstrumentType.Text = value; }
        }
        public string HicenseHolder
        {
            get { return txtLicenseHolder.Text; }
            set { txtLicenseHolder.Text = value; }
        }
        public string User
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }
        public string Customer
        {
            get { return txtCustomer.Text; }
            set { txtCustomer.Text = value; }
        }
        public string Contractor
        {
            get { return txtContractor.Text; }
            set { txtContractor.Text = value; }
        }
        public string BatchOperator
        {
            get { return txtBatchOperator.Text; }
            set { txtBatchOperator.Text = value; }
        }
        public string FilesLocation
        {
            get { return txtFilesLocation.Text; }
            set { txtFilesLocation.Text = value; }
        }
        public string AdditionalInfo
        {
            get { return txtAdditionalInfo.Text; }
            set { txtAdditionalInfo.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        //Methods
        public void SetWellListBindingSource(BindingSource wellList)
        {
            dataGridView1.DataSource = wellList;
        }
        private static WellView instance;
        public static WellView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WellView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

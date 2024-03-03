    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace BDapp.Views
    {
        public interface IWellView
        {
            //Properties - Fields
            string WellId { get; set; }
            string Number { get; set; }
            string Area { get; set; }
            string Cluster { get; set; }
            string InstrumentType { get; set; }
            string HicenseHolder { get; set; }
            string User { get; set; }
            string Customer { get; set; }
            string Contractor { get; set; }
            string BatchOperator { get; set; }
            string FilesLocation { get; set; }
            string AdditionalInfo { get; set; }
            string SearchValue { get; set; }
            bool IsEdit { get; set; }
            bool IsSuccessful { get; set; }
            string Message { get; set; }
            //Events
            event EventHandler SearchEvent;
            event EventHandler AddNewEvent;
            event EventHandler EditEvent;
            event EventHandler DeleteEvent;
            event EventHandler SaveEvent;
            event EventHandler CancelEvent;
            //Methods
            void SetWellListBindingSource(BindingSource wellList);
            void Show();
        }
    }

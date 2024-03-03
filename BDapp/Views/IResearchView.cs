using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDapp.Views
{
    public interface IResearchView
    {
        //Properties - Fields
        string ResearchId { get; set; }
        string Data { get; set; }
        string Method { get; set; }
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
        void SetResearchListBindingSource(BindingSource researchList);
        void Show();
    }
}
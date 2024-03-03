using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDapp.Views
{
        public interface IMainView
        {
            event EventHandler ShowWellView;
            event EventHandler ShowResearchView;
        }
 }


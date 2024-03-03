using BDapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDapp.Models
{
    public interface IWellRepository
    {
        void Add(WellModel wellModel);
        void Edit(WellModel wellModel);
        void Delete(int id);
        IEnumerable<WellModel> GetAll();
        IEnumerable<WellModel> GetByValue(string value);//Searchs
    }
}
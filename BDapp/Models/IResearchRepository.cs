using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDapp.Models;

namespace BDapp.Models
{
    public interface IResearchRepository
    {
        void Add(ResearchModel researchModel);
        void Edit(ResearchModel researchModel);
        void Delete(int id);
        IEnumerable<ResearchModel> GetAll();
        IEnumerable<ResearchModel> GetByValue(string value);//Searchs
    }
}
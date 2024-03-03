
using System;
using BDapp.Views;
using BDapp.Models;
using BDapp._Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDapp._Repositories
{
    public class ResearchRepository : BaseRepository, IResearchRepository
    {
        //Constructor
        public ResearchRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public IEnumerable<ResearchModel> GetAll()
        {
            var researchList = new List<ResearchModel>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Research order by Research_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var researchModel = new ResearchModel();
                        researchModel.Id = (int)reader[0];
                        researchModel.Data = (int)reader[1];
                        researchModel.Method = reader[2].ToString();
                        researchList.Add(researchModel);
                    }
                }
            }
            return researchList;
        }
        public IEnumerable<ResearchModel> GetByValue(string value)
        {
            var researchList = new List<ResearchModel>();
            int researchId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string method = value;
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from research
                                        whereResearch_Id=@id or Method like @Method+'%' 
                                        order by Research_Id desc";
                command.Parameters.Add("@id", DbType.Int32).Value = researchId;
                command.Parameters.Add("@method", DbType.String).Value = method;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var researchModel = new ResearchModel();
                        researchModel.Id = (int)reader[0];
                        researchModel.Data = (int)reader[1];
                        researchModel.Method = reader[2].ToString();                       
                        researchList.Add(researchModel);
                    }
                }
            }
            return researchList;
        }
        public void Add(ResearchModel researchModel)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Edit(ResearchModel researchModel)
        {
            throw new NotImplementedException();
        }
    }
}
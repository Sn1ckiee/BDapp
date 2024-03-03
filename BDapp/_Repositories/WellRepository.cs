using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDapp.Models;
using BDapp.Views;
using BDapp._Repositories;
using System.Resources;

namespace BDapp._Repositories
{
    public class WellRepository : BaseRepository, IWellRepository
    {
        //Constructor
        public WellRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public IEnumerable<WellModel> GetAll()
        {
            var wellList = new List<WellModel>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Well order by Well_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var wellModel = new WellModel();
                        wellModel.Id = (int)reader[0];
                        wellModel.Number = (int)reader[1];
                        wellModel.Area = reader[2].ToString();
                        wellModel.Cluster = reader[3].ToString();
                        wellModel.InstrumentType = reader[4].ToString();
                        wellModel.HicenseHolder = reader[5].ToString();
                        wellModel.User = reader[6].ToString();
                        wellModel.Customer = reader[7].ToString();
                        wellModel.Contractor = reader[8].ToString();
                        wellModel.BatchOperator = reader[9].ToString();
                        wellModel.FilesLocation = reader[10].ToString();
                        wellModel.AdditionalInfo = reader[11].ToString();
                        wellList.Add(wellModel);
                    }
                }
            }
            return wellList;
        }
        public IEnumerable<WellModel> GetByValue(string value)
        {
            var wellList = new List<WellModel>();
            int wellId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string area = value;
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from well
                                        where Well_Id=@id or InstrumentType like @area+'%' 
                                        order by Well_Id desc";
                command.Parameters.Add("@id", DbType.Int32).Value = wellId;
                command.Parameters.Add("@area", DbType.String).Value = area;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var wellModel = new WellModel();
                        wellModel.Id = (int)reader[0];
                        wellModel.Number = (int)reader[1];
                        wellModel.Area = reader[2].ToString();
                        wellModel.Cluster = reader[3].ToString();
                        wellModel.InstrumentType = reader[4].ToString();
                        wellModel.HicenseHolder = reader[5].ToString();
                        wellModel.User = reader[6].ToString();
                        wellModel.Customer = reader[7].ToString();
                        wellModel.Contractor = reader[8].ToString();
                        wellModel.BatchOperator = reader[9].ToString();
                        wellModel.FilesLocation = reader[10].ToString();
                        wellModel.AdditionalInfo = reader[11].ToString();
                        wellList.Add(wellModel);
                    }
                }
            }
            return wellList;
        }
        public void Add(WellModel wellModel)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Edit(WellModel wellModel)
        {
            throw new NotImplementedException();
        }
    }
}
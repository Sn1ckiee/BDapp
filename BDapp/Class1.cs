using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BDapp.Models
{
    public class SQLiteDB
    {
        // ... (предыдущий код)

        public void CreateWellTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=WellsBD.db;Version=3;"))
            {
                connection.Open();

                string createWellTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Well (
                        id INTEGER PRIMARY KEY,
                        number INTEGER,
                        area TEXT NOT NULL,
                        cluster TEXT NOT NULL,
                        instrumentType TEXT NOT NULL,
                        hicenseHolder TEXT NOT NULL,
                        user TEXT NOT NULL,
                        customer TEXT NOT NULL,
                        contractor TEXT NOT NULL,
                        batchOperator TEXT NOT NULL,
                        filesLocation TEXT NOT NULL,
                        additionalInfo TEXT NOT NULL
                    );";

                using (SQLiteCommand command = new SQLiteCommand(createWellTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateResearchTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=WellsBD.db;Version=3;"))
            {
                connection.Open();

                string createResearchTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Research (
                        id INTEGER PRIMARY KEY,
                        data INTEGER NOT NULL,
                        method TEXT NOT NULL
                    );";

                using (SQLiteCommand command = new SQLiteCommand(createResearchTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
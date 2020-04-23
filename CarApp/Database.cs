using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Database
    {
        public SQLiteConnection dbConn; // Håller i "connection" mot databasen
        private string databaseFilename = "./car.db"; // Sökväg till databasen

        public Database()
        {
            // Skapa databasen
            if(!File.Exists(databaseFilename))
            {
                File.Create(databaseFilename);
            }
            // Skapa dbConn, det objekt som håller förbindelsen med databasen
            dbConn = new SQLiteConnection("Data Source=" + databaseFilename);
        }
        /// <summary>
        /// Öppnar kopplingen till databasen
        /// Om dbConn inte är öppen så öppna dbConn
        /// </summary>
        public void OpenConnection()
        {
            if(dbConn.State != System.Data.ConnectionState.Open)
            {
                dbConn.Open();
            }
        }
        public void CloseConnection()
        {
            if(dbConn.State != System.Data.ConnectionState.Closed)
            {
                dbConn.Close();
            }
        }

        public int AddCarRow(Car car)
        {
            string qInsert = "INSERT INTO CAR ('regNr', 'brand', 'model', 'year', 'forSale') VALUES (@regNr, @brand, @model, @year, @forSale);";

            SQLiteCommand dbCommand = new SQLiteCommand(qInsert, dbConn);
            OpenConnection();

            dbCommand.Parameters.AddWithValue(@"regNr", car.GetRegNr());
            dbCommand.Parameters.AddWithValue(@"brand", car.GetBrand());
            dbCommand.Parameters.AddWithValue(@"model", car.GetModel());
            dbCommand.Parameters.AddWithValue(@"year", car.GetYear());
            dbCommand.Parameters.AddWithValue(@"forSale", Convert.ToInt32(car.GetForSale()));

            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;
        }
    }
}

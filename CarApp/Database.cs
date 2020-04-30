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

        public List<Car> GetAllRowsFromCar()
        {
            string qSelect = "SELECT * FROM car; ";
            List<Car> listOfCars = new List<Car>();

            SQLiteCommand dbCommand = new SQLiteCommand(qSelect, dbConn);
            OpenConnection();

            SQLiteDataReader res = dbCommand.ExecuteReader(); //ett resultatset, vilket är en tvådimensionell array med värden.

            if(res.HasRows)
            {
                while (res.Read()) {
                    Car car = new Car(Convert.ToString(res["regNr"]),
                        Convert.ToString(res["brand"]),
                        Convert.ToString(res["model"]),
                        Convert.ToInt32(res["year"]),
                        Convert.ToBoolean(res["forSale"])
                        );
                    listOfCars.Add(car);
                }
            }
            CloseConnection();

            return listOfCars;
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

        public int RemoveCarRowByRegNr(string regNr)
        {
            string qDelete = "DELETE FROM car WHERE regNr = @regNr;";

            SQLiteCommand dbCommand = new SQLiteCommand(qDelete, dbConn);
            OpenConnection();

            //kopplar parameter
            dbCommand.Parameters.AddWithValue(@"regNr", regNr);

            //Svaret är hur många rader som påverkas av "frågan" jag ställer
            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Car
    {
        private string regNr;
        private string brand;
        private string model;
        private int year;
        private bool forSale;

        public Car(string regNr, string brand, string model, int year, bool forSale)
        {
            this.regNr = regNr;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.forSale = forSale;
        }

        public string GetRegNr()
        {
            return regNr;
        }
        public string GetBrand()
        {
            return brand;
        }
        public string GetModel()
        {
            return model;
        }
        public int GetYear()
        {
            return year;
        }
        public bool GetForSale()
        {
            return forSale;
        }

        public void SetRegNr(string regNr)
        {
            this.regNr = regNr;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public void SetForSale(bool forSale)
        {
            this.forSale = forSale;
        }

    }
}

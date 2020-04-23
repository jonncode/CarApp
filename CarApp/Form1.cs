using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CarApp
{
    public partial class Form1 : Form
    {
        Database dbObject = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        #region EVENTS


        /// <summary>
        /// Lägger till när användaren klickar på "lägg till" knappen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tBRegNr.Text) || string.IsNullOrEmpty(tBBrand.Text))
            {
                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            }
            else
            {
                Car car = new Car(tBRegNr.Text, tBBrand.Text, tBModel.Text, Convert.ToInt32(tBYear.Text), cBForSale.Checked);

                //Lägg till bilen i databasen
                int result = dbObject.AddCarRow(car);
                MessageBox.Show("Du har lagt till " + Convert.ToString(result) + " antal bilar");
                ListViewItem item = CreateListViewItem(tBRegNr.Text, tBBrand.Text, tBModel.Text, tBYear.Text, cBForSale.Checked);
                LVCars.Items.Add(item);
                ClearTextBoxes();
                btnClear.Enabled = true;
            }
        }
        /// <summary>
        /// Tar bort en bil när användaren klickar på knappen "Ta bort markerad bil"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LVCars.SelectedItems.Count > 0)
            {
                var item = LVCars.SelectedItems[0];
                LVCars.Items.Remove(item);
                MessageBox.Show("bilen med registeringsnummer " + item.Text + " är borttagen", "Borttag av bil");
            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort", "Borttag av bil");
            }
            btnClear.Enabled = (LVCars.Items.Count > 0);
        }
        /// <summary>
        /// Säkerställer att knappen "ta bort markerad bil" bara är tillgänglig när det verkligen finns en bil markerad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lVCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (LVCars.SelectedItems.Count > 0);
        }
        /// <summary>
        /// Rensar bort alla bilar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            LVCars.Clear();
        }

        #endregion EVENTS

        #region HELPFUNCTIONS

        /// <summary>
        /// Hjälpfunktion till btnAdd_Click
        /// </summary>
        /// <param name="regNr">Text i textbox för RegNr</param>
        /// <param name="brand">Text i textbox för Märke</param>
        /// <param name="model">Text i textbox för Model</param>
        /// <param name="year">Text i textbox för Year</param>
        /// <param name="forSale">True om den är till salu, falsk annars</param>
        /// <returns></returns>
        private ListViewItem CreateListViewItem(string regNr, string brand, string model, string year, bool forSale)
        {
            ListViewItem item = new ListViewItem(regNr);
            item.SubItems.Add(brand);
            item.SubItems.Add(model);
            item.SubItems.Add(year);
            item.SubItems.Add(forSale ? "Yes" : "No");
            return item;
        }
        /// <summary>
        /// Rensar alla textfält och sätter regnummer till att vara i fokus
        /// </summary>
        private void ClearTextBoxes()
        {
            tBBrand.Clear();
            tBModel.Clear();
            tBRegNr.Clear();
            tBYear.Clear();
            cBForSale.Checked = false;
            tBRegNr.Focus();
        }

        #endregion HELPFUNCTIONS

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBRegNr.Text))
            {
                string regNr = tBRegNr.Text.ToUpper();
                PrintData(regNr);
            }
            else
            {
                MessageBox.Show("Du måste ange ett registreringsnummer", "Inmatning saknas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintData(string regNr)
        {

            // https://api.biluppgifter.se/api/v1/vehicle/regno/XNF905?api_token=DtIAxcVeOZhJzLnC6LYN3BjwasJw2FIA5hdvgP00lNKw1cM53ddy1iWpll54

            string token = "DtIAxcVeOZhJzLnC6LYN3BjwasJw2FIA5hdvgP00lNKw1cM53ddy1iWpll54";
            string call = String.Format($"https://api.biluppgifter.se/api/v1/vehicle/regno/{regNr}?api_token={token}");

            try
            {
                WebRequest request = HttpWebRequest.Create(call);

                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string carJSON = reader.ReadToEnd();

                JObject jsonCar = JObject.Parse(carJSON);

                tBBrand.Text = jsonCar["data"]["basic"]["data"]["make"].ToString();
                tBYear.Text = jsonCar["data"]["basic"]["data"]["model_year"].ToString();
                tBModel.Text = jsonCar["data"]["basic"]["data"]["model"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bil med registeringsnummer {regNr} kunde inte hittas \n\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

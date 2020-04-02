using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
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
                ListViewItem item = CreateListViewItem(tBRegNr.Text, tBBrand.Text, tBModel.Text, tBYear.Text, cBForSale.Checked);
                lVCars.Items.Add(item);
                ClearTextBoxes();
            }
        }
        /// <summary>
        /// Tar bort en bil när användaren klickar på knappen "Ta bort markerad bil"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lVCars.SelectedItems.Count > 0)
            {
                var item = lVCars.SelectedItems[0];
                lVCars.Items.Remove(item);
                MessageBox.Show("bilen med registeringsnummer " + item.Text + " är borttagen", "Borttag av bil");
            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort", "Borttag av bil");
            }
            btnClear.Enabled = (lVCars.Items.Count > 0);
        }
        /// <summary>
        /// Säkerställer att knappen "ta bort markerad bil" bara är tillgänglig när det verkligen finns en bil markerad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lVCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lVCars.SelectedItems.Count > 0);
        }
        /// <summary>
        /// Rensar bort alla bilar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lVCars.Clear();
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
            item.SubItems.Add(forSale ? "Yes" : "No");
            item.SubItems.Add(year);
            item.SubItems.Add(model);
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
    }
}

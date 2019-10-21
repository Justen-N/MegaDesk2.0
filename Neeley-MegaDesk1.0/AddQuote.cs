using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neeley_MegaDesk1._0
{
    public partial class AddQuote : Form
    {
        DeskQuote quote;
        public AddQuote()
        {
            InitializeComponent();
            
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            quote = new DeskQuote();
            SurfaceMaterialDropDown.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            ValidateDisplay.Visible = false;
            ShippingDays.DataSource = new RushDays[]
                {
                    new RushDays{ID = 0, Text = "Standard (14 Days)"},
                    new RushDays{ID = 3, Text = "Three Day (3 Days)"},
                    new RushDays{ID = 5, Text = "Five Day (5 Days)"},
                    new RushDays{ID = 7, Text = "One Week (7 Days)"}
                };

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try {
                quote.desk.DeskDepth = (int)DepthDropdown.Value;
                quote.desk.DeskWidth = (int)WidthDropdown.Value;
                quote.desk.NumDrawers = (int)NumDrawerSelect.Value;
                SurfaceMaterial material;
                Enum.TryParse<SurfaceMaterial>(SurfaceMaterialDropDown.SelectedValue.ToString(), out material);
                quote.desk.Material = material;
                quote.FirstName = FirstNameInput.Text;
                quote.LastName = LastNameInput.Text;
                quote.NumRushDays = (int)ShippingDays.SelectedValue;

                TotalPriceDisplay.Text = quote.calculatePrice().ToString();
                CalculateButton.Enabled = false;
                ValidateDisplay.Visible = true;

            }
            catch (InvalidOperationException)
            {
                 MessageBox.Show("Unable to create the quote.", "Data Saving Failed", MessageBoxButtons.AbortRetryIgnore);
                 
            }
        }
        private void RejectQuoteButton_Click(object sender, EventArgs e)
        {
            quote = new DeskQuote();
            ValidateDisplay.Visible = false;
            CalculateButton.Enabled = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            quote.SerializeQuote(quote);
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Neeley_MegaDesk1._0
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            CheckValidFile();
            
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        // Load the Json File and display
        private void CheckValidFile()
        {
            if (!IsFileValid("quotes.Json"))
            {
                MessageBox.Show(string.Format("No Current Quotes"));
            }
            else
            {
                LoadJson();
            }
        }

        private bool IsFileValid(string filePath)
        {
            bool isValid = true;
            if (!File.Exists(filePath))
            {
                isValid = false;
            }
            else if (Path.GetExtension(filePath).ToLower() != ".json")
            {
                isValid = false;
            }

            return isValid;
        }

        private void LoadJson()
        {
            using (StreamReader sr = new StreamReader("quotes.Json"))
            {
               string json = sr.ReadToEnd();
                                
                dynamic result = JsonConvert.DeserializeObject(json);
                                
                viewAllQuotesGridView.DataSource = result;
            }
        }

        private void ViewAllQuotesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

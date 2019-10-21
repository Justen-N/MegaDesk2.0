using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Neeley_MegaDesk1._0
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

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

                searchAllQuotesGridView.DataSource = result;
            }
        }
    }
}

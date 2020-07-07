using SqlHelprepForDataBase;
using System;
using System.Net;
using System.Windows.Forms;
using TakeInfoAboutCountry.Forms;

namespace TakeInfoAboutCountry
{
    public partial class StartMenu:Form
    {
        private void OpenFormAddNewCountry()
        {
            if(CheckInternetConnection())
            {
                var enterNameCountryMenu = new EnterNameCountryMenu(_sqlHelper);
                enterNameCountryMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Отсутвует подлкючение к интернету.\nПродолжить невозможно.");
            }  
        }

        private bool CheckInternetConnection()
        {
            try
            {
                using(var client = new WebClient())
                using(var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch(WebException)
            {
                return false;
            }
        }

        private void OpenFormShowAllInfoFromDataBase()
        {
            var showAllNameCountyMenu = new ShowAllNameCountryMenu(_sqlHelper);
            showAllNameCountyMenu.ShowDialog();
        }

        private void InitializationConnectionToDataBase()
        {
            _sqlHelper = new SqlHelper(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\InColumi\Desktop\Projects\TakeInfoAboutCountry\TakeInfoAboutCountry\DataBase\Country.mdf;Integrated Security=True");
        }

        private void CloseStartMenu()
        {
            if(_sqlHelper != null)
            {
                _sqlHelper.TryCloseConnection();
            }
        }
    }
}

using SearchByCountry;
using SqlHelprepForDataBase;
using System;
using System.Net;
using System.Windows.Forms;
using TakeInfoAboutCountry.Forms;

namespace TakeInfoAboutCountry
{
    public partial class StartMenu:Form
    {
        public Search _search;
        public SqlHelper _sqlHelper;

        public StartMenu()
        {
            InitializeComponent();
        }

        private void ButtonEnterNameCountry_Click(object sender, EventArgs e)
        {
            OpenFormAddNewCountry();
        }        

        private void ButtonShowAllCountryFromDB_Click(object sender, EventArgs e)
        {
            OpenFormShowAllInfoFromDataBase();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            InitializationConnectionToDataBase();
        }

        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseStartMenu();
        }
    }
}

using SqlHelprepForDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TakeInfoAboutCountry.Forms
{
    public partial class ShowAllNameCountryMenu:Form
    {
        private SqlHelper _sqlHelper;
        public ShowAllNameCountryMenu(SqlHelper sqlHelper)
        {
            InitializeComponent();
            _sqlHelper = sqlHelper;
            ShowAllDataFromDB();
        }
    }
}

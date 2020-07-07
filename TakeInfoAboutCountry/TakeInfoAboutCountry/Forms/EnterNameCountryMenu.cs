using SearchByCountry;
using SqlHelprepForDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TakeInfoAboutCountry.Forms
{
    public partial class EnterNameCountryMenu:Form
    {
        public SqlHelper _sqlHelper;
        public Search _search;
        public EnterNameCountryMenu(SqlHelper sqlHelper)
        {
            InitializeComponent();
            _sqlHelper = sqlHelper;
        }

        private void TextBoxInputNameCountry_Click(object sender, EventArgs e)
        {
            DeletePlaceHolder();
        }

        private void TextBoxInputNameCountry_Leave(object sender, EventArgs e)
        {
            FillPlaceHolder();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            FindInfoByCountry(textBoxInputNameCountry.Text);
        }

        private void TextBoxInputNameCountry_KeyDown(object sender, KeyEventArgs e)
        {
            DeletePlaceHolder();
            if(e.KeyCode == Keys.Enter)
            {
                buttonFind.PerformClick();
            }
        }

        private void ButtonAddToDB_Click(object sender, EventArgs e)
        {
            AddToDB();
        }
    }
}

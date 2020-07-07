using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeInfoAboutCountry.Forms
{
    public partial class ShowAllNameCountryMenu:Form
    {
        private void ShowAllDataFromDB()
        {
            try
            {
                string sqrlRequest = "SELECT Country.Name, Country.CountryCode, Towns.Name, Country.Area, Country.Population, Regions.Name " +
                    "FROM Country, Regions, Towns " +
                    "WHERE Country.Capital = Towns.Id AND Country.Region = Regions.Id";

                SqlCommand command = new SqlCommand(sqrlRequest, _sqlHelper.Connection);

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    List<string[]> data = new List<string[]>();
                    int sizeRow = reader.FieldCount;
                    string[] temp = new string[sizeRow];
                    while(reader.Read())
                    {
                        for(int i = 0; i < sizeRow; i++)
                        {
                            temp[i] = reader[i].ToString();
                        }
                        dataGridViewShowInfo.Rows.Add(temp);
                    }

                    reader.Close();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

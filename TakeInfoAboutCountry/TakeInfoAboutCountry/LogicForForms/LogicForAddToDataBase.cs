using SearchByCountry;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace TakeInfoAboutCountry.Forms
{
    public partial class EnterNameCountryMenu:Form
    {
        private void FillPlaceHolder()
        {
            if(textBoxInputNameCountry.Text == "")
            {
                textBoxInputNameCountry.Text = "Введите название страны";
                textBoxInputNameCountry.ForeColor = Color.Gray;
            }
        }

        private void DeletePlaceHolder()
        {
            if(textBoxInputNameCountry.Text == "Введите название страны")
            {
                textBoxInputNameCountry.Clear();
                textBoxInputNameCountry.ForeColor = Color.Black;
            }
        }

        private void FindInfoByCountry(string countryName)
        {
            _search = new Search(countryName);
            _search.SetResaltByPatterns();
            UpdatingTextBox(_search.Resalt);
        }

        private void UpdatingTextBox(string[] texts)
        {
            textBoxCountryName.Text = texts[0];
            textBoxNumbeOfCountry.Text = texts[1];
            textBoxCapital.Text = texts[2];
            textBoxArea.Text = texts[3];
            textBoxPopulation.Text = texts[4];
            textBoxRegion.Text = texts[5];
        }

        private bool IsEmptyPlaceInTextBox()
        {
            if(textBoxCountryName.Text == "" ||
                textBoxArea.Text == "" ||
                textBoxCapital.Text == "" ||
                textBoxNumbeOfCountry.Text == "" ||
                textBoxPopulation.Text == "" ||
                textBoxRegion.Text == "")
            {
                return false;
            }
            return true;
        }

        private void AddToDB()
        {
            if(IsEmptyPlaceInTextBox())
            {
                List<string[]> dataFromTowns = GetValueFromDataBase("SELECT * FROM Towns");
                List<string[]> dataFromRegions = GetValueFromDataBase("SELECT * FROM Regions");
                List<string[]> dataFromCountry = GetValueFromDataBase("SELECT * FROM Country");

                int indexRowTown;
                int indexRowRegion;
                int indexRowCountry;

                bool isTown = CheckValueInDataBase(textBoxCapital.Text, dataFromTowns, 1, out indexRowTown);
                bool isRegion = CheckValueInDataBase(textBoxRegion.Text, dataFromRegions, 1, out indexRowRegion);
                bool isCountry = CheckValueInDataBase(textBoxCountryName.Text, dataFromCountry, 1, out indexRowCountry);

                string idTown;
                string idRegion;

                if(isTown)
                {
                    idTown = dataFromTowns[indexRowTown][0];
                }
                else
                {
                    AddNewDataToTownsOrRegions(textBoxCapital.Text, "Towns");
                    idTown = (dataFromTowns.Count + 1).ToString();
                }

                if(isRegion)
                {
                    idRegion = dataFromRegions[indexRowRegion][0];
                }
                else
                {
                    AddNewDataToTownsOrRegions(textBoxRegion.Text, "Regions");
                    idRegion = (dataFromRegions.Count + 1).ToString();
                }

                if(isCountry)
                {
                    UpdateDataInCountry(indexRowCountry);
                }
                else
                {
                    AddNewDataToCountry(idTown, idRegion);
                }
            }
            else
            {
                MessageBox.Show("Поля пустые.\nДобавить в базу не возможно.");
            }
        }

        private void UpdateDataInCountry(int indexRowCountry)
        {
            try
            {
                float area = float.Parse(textBoxArea.Text.Replace('.', ','));
                Int64 popularion = Convert.ToInt64(textBoxPopulation.Text);

                string sqlQuery = "UPDATE Country " +
                    $"SET Area = {area}, Population = {popularion} " +
                    $"WHERE Id = {indexRowCountry + 1}";
                
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, _sqlHelper.Connection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные обновлены.");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddNewDataToCountry(string idTown, string idRegion)
        {
            try
            {
                float area = float.Parse(textBoxArea.Text.Replace('.', ','));
                Int64 popularion = Convert.ToInt64(textBoxPopulation.Text);

                string sqlQuery = "INSERT INTO Country " +
                    "VALUES(@Name, @CountryCode, @Capital, @Area, @Population, @Region)";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, _sqlHelper.Connection);

                sqlCommand.Parameters.AddWithValue("Name", textBoxCountryName.Text);
                sqlCommand.Parameters.AddWithValue("CountryCode", textBoxNumbeOfCountry.Text);
                sqlCommand.Parameters.AddWithValue("Capital", idTown);
                sqlCommand.Parameters.AddWithValue("Area", area);
                sqlCommand.Parameters.AddWithValue("Population", popularion);
                sqlCommand.Parameters.AddWithValue("Region", idRegion);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Новая страна добавлена в базу данных.");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddNewDataToTownsOrRegions(string newValue, string nameTable)
        {
            try
            {
                string sqlQuery = $"INSERT INTO {nameTable} " +
                    $"VALUES(@Name)";
                using(SqlCommand sqlCommand = new SqlCommand(sqlQuery, _sqlHelper.Connection))
                {
                    sqlCommand.Parameters.AddWithValue("Name", newValue);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool CheckValueInDataBase(string value, List<string[]> dataFromDB, int indexColumn, out int indexValue)
        {
            indexValue = - 1;
            for(int i = 0; i < dataFromDB.Count; i++)
            {
                if(value == dataFromDB[i][indexColumn])
                {
                    indexValue = i;
                    return true;
                }
            }
            return false;
        }

        private List<string[]> GetValueFromDataBase(string sqlRequest)
        {
            try
            {
                SqlCommand command = new SqlCommand(sqlRequest, _sqlHelper.Connection);
                List<string[]> dataFromDataBase = new List<string[]>();

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int sizeRow = reader.FieldCount;
                        string[] rowData = new string[sizeRow];
                        for(int i = 0; i < sizeRow; i++)
                        {
                            rowData[i] = reader[i].ToString();
                        }

                        dataFromDataBase.Add(rowData);
                    }
                    reader.Close();
                }
                return dataFromDataBase;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}

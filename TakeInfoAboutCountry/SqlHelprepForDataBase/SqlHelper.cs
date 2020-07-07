using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlHelprepForDataBase
{
    public class SqlHelper
    {
        public SqlConnection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public SqlHelper(string path)
        {
            ConnectionString = path;
            Connection = new SqlConnection(ConnectionString);
            TryOpenConnection();
        }

        private void TryOpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Exit();
            }
        }

        public void TryCloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Exit();
            }
        }
    }
}

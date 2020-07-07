using System;
using System.Windows.Forms;

namespace SqlHelper
{
    class SqlHelper:IDisposable
    {
        public SqlConnection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public SqlHelper(string path)

        {
            ConnectionString = path;
            Connection = new SqlConnection(ConnectionString);
            TryConnect();
        }

        private void TryConnect()
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

        public void Dispose()
        {
            Connection.Close();
        }
    }
}

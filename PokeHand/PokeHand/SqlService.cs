using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeHand
{
    class SqlService
    {
        private SqlConnection connection;

        public SqlService()
        {
            string connectionString = Properties.Settings.Default.PokeHandConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            this.connection.Open();
        }

        public void CloseConnection()
        {
            this.connection.Close();
        }

        public void DMLCommand(string command, SqlParameter[] parameters)
        {
            SqlCommand sqlCommand = new SqlCommand(command, this.connection);
            foreach(SqlParameter parameter in parameters)
            {
                sqlCommand.Parameters.Add(parameter.GetColumn(), parameter.GetType());
                sqlCommand.Parameters[parameter.GetColumn()].Value = parameter.GetValue();
            }

            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)  this.OpenConnection();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro ao abrir a conexão com o Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw error;
            }

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro ao executar o comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw error;
            }
        }

        public SqlDataReader DQLCommand(string command, SqlParameter[] parameters)
        {
            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand(command, this.connection);
            foreach (SqlParameter parameter in parameters)
            {
                sqlCommand.Parameters.Add(parameter.GetColumn(), parameter.GetType());
                sqlCommand.Parameters[parameter.GetColumn()].Value = parameter.GetValue();
            }

            try
            {
                if(this.connection.State == System.Data.ConnectionState.Closed) this.OpenConnection();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Erro ao abrir a conexão com o Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw error;
            }

            try
            {
                reader = sqlCommand.ExecuteReader();
                return reader;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro ao executar o comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw error;
            }
        }
    }
}

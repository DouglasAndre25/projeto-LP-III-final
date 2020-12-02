using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeHand {
    public partial class Types : Form {
        public Types() {
            InitializeComponent();
        }

        private void Types_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'pokeHandDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);
            // TODO: This line of code loads data into the 'pokeHandDataSet.attack' table. You can move, or remove it, as needed.
            this.attackTableAdapter.Fill(this.pokeHandDataSet.attack);

        }

        private void UpdateTypes()
        {
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);
        }

        private void ClearFields()
        {
            inputTypeAddName.Clear();
            inputTypeAddName.Focus();
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;

            string connectionString = Properties.Settings.Default.PokeHandConnectionString;
            connection = new SqlConnection(connectionString);

            command = new SqlCommand(
                "INSERT INTO type (name) VALUES (@name)", connection
            );

            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
            command.Parameters["@name"].Value = inputTypeAddName.Text;

            try
            {
                try
                {
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao abrir a conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao executar o comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            finally
            {
                connection.Close();

                MessageBox.Show("Tipo Cadastrado!", "Tipo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.UpdateTypes();
                this.ClearFields();
            }
        }

        private void searchTypeButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.PokeHandConnectionString;
            connection = new SqlConnection(connectionString);

            command = new SqlCommand(
                "SELECT name FROM type WHERE name LIKE '%@name%'", connection
            );

            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
            command.Parameters["@name"].Value = inputTypeAddName.Text;

            try
            {

                try
                {
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao abrir a conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    reader = command.ExecuteReader();

                    MessageBox.Show(reader.Read().ToString(), "Erro ao executar o comando SQL",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (reader.Read())
                    {
                       
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao executar o comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

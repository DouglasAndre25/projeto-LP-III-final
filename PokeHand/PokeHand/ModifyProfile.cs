using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PokeHand
{
    public partial class ModifyProfile : Form
    {

        private SqlService sqlService;

        public ModifyProfile()
        {
            InitializeComponent();
            sqlService = new SqlService();
            this.VerifyProfile();
        }

        private void VerifyProfile()
        {

            try
            {
                try
                {
                    SqlParameter[] parameters = { };
                    SqlDataReader reader = sqlService.DQLCommand("SELECT * FROM trainer WHERE id = '1';", parameters);

                    if (reader.HasRows)
                    {
                        reader.Read();
                        inputProfileName.Text = reader["name"].ToString();
                        inputProfileAge.Text = reader["age"].ToString();
                        inputProfileVocation.SelectedItem = reader["vocation"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        sqlService.DMLCommand("INSERT INTO trainer (name, age, vocation) VALUES ('', 0, '');", parameters);
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            finally
            {
                sqlService.CloseConnection();
            }
        }

        private void profileSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@name", SqlDbType.NVarChar, inputProfileName.Text),
                        new SqlParameter("@age", SqlDbType.Int, Convert.ToInt32(inputProfileAge.Text)),
                        new SqlParameter("@vocation", SqlDbType.NVarChar, inputProfileVocation.SelectedItem) 
                    };
                    sqlService.DMLCommand("UPDATE trainer SET name=@name, age=@age, vocation=@vocation WHERE id=1;", parameters);

                    MessageBox.Show("Dados do pefil atualizados!", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            finally
            {
                sqlService.CloseConnection();
            }
        }
    }
}

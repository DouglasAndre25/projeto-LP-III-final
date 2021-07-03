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


        private string modifyTypeSelectedIndex;
        private string deleteTypeSelectedIndex;
        private SqlService sqlService;

        public Types() {
            InitializeComponent();
            sqlService = new SqlService();
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

            if (string.IsNullOrWhiteSpace(inputTypeAddName.Text))
            {
                typeErrorProvider.SetError(inputTypeAddName, "O Campo obrigatório.");
                return;
            }
            else
            {
                typeErrorProvider.Clear();
            }

            try
            {
                try
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@name", SqlDbType.NVarChar, inputTypeAddName.Text)
                    };
                    sqlService.DMLCommand("INSERT INTO type (name) VALUES (@name)", parameters);
                    MessageBox.Show("Tipo cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.UpdateTypes();
                this.ClearFields();
            }
        }

        private void searchTypeButton_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    SqlParameter[] parameters = {};
                    SqlDataReader reader = sqlService.DQLCommand(
                        $"EXEC type_by_name @name = '{inputTypeSearchName.Text}'", parameters
                    );
                    PokeHandDataSet.typeDataTable dataTable = new PokeHandDataSet.typeDataTable();
                    dataTable.Load(reader);
                    typeSearchGridView.DataSource = dataTable;
                }
                catch (Exception error) 
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                inputTypeSearchName.Clear();
            }
           
        }

        private void typeModifyGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.typeModifyGridView.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.modifyTypeSelectedIndex = this.typeModifyGridView.SelectedRows[0].Cells["typeModifyGridViewId"].Value.ToString();
                inputTypeModifyName.Text = this.typeModifyGridView.SelectedRows[0].Cells["typeModifyGridViewName"].Value.ToString();
            }
        }

        private void modifyTypeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTypeModifyName.Text))
            {
                typeErrorProvider.SetError(inputTypeModifyName, "Campo obrigatório.");
                return;
            }
            else
            {
                typeErrorProvider.Clear();
            }


            try
            {
                try
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@name", System.Data.SqlDbType.NVarChar, inputTypeModifyName.Text),
                        new SqlParameter("@id", System.Data.SqlDbType.NVarChar, this.modifyTypeSelectedIndex)
                    };
                    sqlService.DMLCommand("UPDATE type SET name=@name WHERE id=@id", parameters);

                    MessageBox.Show("Tipo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                inputTypeModifyName.Clear();
                this.UpdateTypes();
            }


        }

        private void typeDeleteGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.typeDeleteGridView.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.deleteTypeSelectedIndex = this.typeDeleteGridView.SelectedRows[0].Cells["typeDeleteGridViewId"].Value.ToString();
            }
        }

        private void deleteTypeButton_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@id", System.Data.SqlDbType.NVarChar, this.deleteTypeSelectedIndex)
                    };
                    sqlService.DMLCommand("DELETE FROM type WHERE id = @id", parameters);
                    MessageBox.Show("Tipo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.UpdateTypes();
            }

        }

    }
}

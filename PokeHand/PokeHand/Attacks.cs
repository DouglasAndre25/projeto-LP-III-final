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
    public partial class Attacks : Form
    {

        private SqlService sqlService;
        private string modifyAttackSelectedIndex;
        private string deleteAttackSelectedIndex;

        public Attacks()
        {
            InitializeComponent();
            sqlService = new SqlService();
        }

        private void Attacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.attackType' table. You can move, or remove it, as needed.
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);
            // TODO: This line of code loads data into the 'pokeHandDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);

        }

        private void addAttackButton_Click(object sender, EventArgs e)
        {
            attacksErrorProvider.Clear();
            bool hasErrors = false;
            if(string.IsNullOrWhiteSpace(inputAttackAddName.Text))
            {
                attacksErrorProvider.SetError(inputAttackAddName, "Campo obrigatório.");
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackAddName, "");
            }

            if (string.IsNullOrWhiteSpace(inputAttackAddDamage.Text) || !double.TryParse(inputAttackAddDamage.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputAttackAddDamage.Text) ? "Campo obrigatório." : "Deve ser um double.";
                attacksErrorProvider.SetError(inputAttackAddDamage, errorMessage);
                hasErrors = true;
            }  else
            {
                attacksErrorProvider.SetError(inputAttackAddDamage, "");
            }

            if (string.IsNullOrWhiteSpace(inputAttackAddPowerPoint.Text) || !int.TryParse(inputAttackAddPowerPoint.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputAttackAddPowerPoint.Text) ? "Campo obrigatório." : "Deve ser um número.";
                attacksErrorProvider.SetError(inputAttackAddPowerPoint, errorMessage);
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackAddPowerPoint, "");
            }

            if (string.IsNullOrWhiteSpace(inputAttackAddAccuracy.Text) || !double.TryParse(inputAttackAddAccuracy.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputAttackAddAccuracy.Text) ? "Campo obrigatório." : "Deve ser um double.";
                attacksErrorProvider.SetError(inputAttackAddAccuracy, errorMessage);
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackAddAccuracy, "");
            }

            if (hasErrors)
                return;
            else
                attacksErrorProvider.Clear();

            try
            {
                MessageBox.Show(inputAttackAddType.SelectedValue.ToString());

                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", System.Data.SqlDbType.NVarChar, inputAttackAddName.Text),
                    new SqlParameter("@damage", System.Data.SqlDbType.Real, Convert.ToDouble(inputAttackAddDamage.Text)),
                    new SqlParameter("@pp", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddPowerPoint.Text)),
                    new SqlParameter("@accuracy", System.Data.SqlDbType.Real, Convert.ToDouble(inputAttackAddAccuracy.Text)),
                    new SqlParameter("@typeId", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddType.SelectedValue))
                };
                sqlService.DMLCommand("INSERT INTO attack (name, damage, power_point, accuracy, type_id) VALUES (@name, @damage, @pp, @accuracy, @typeId)", parameters);
                MessageBox.Show("Ataque salvo!", "Ataque",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error) {
                MessageBox.Show(error.Message, "Ataque",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.UpdateAttack();
                this.ClearFields();
                this.sqlService.CloseConnection();
            }
        }

        private void UpdateAttack()
        {
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);
        }

        private void ClearFields()
        {
            inputAttackAddAccuracy.Clear();
            inputAttackAddDamage.Clear();
            inputAttackAddName.Clear();
            inputAttackAddPowerPoint.Clear();
            inputAttackAddName.Focus();
            inputAttackModifyAccuracy.Clear();
            inputAttackModifyDamage.Clear();
            inputAttackModifyName.Clear();
            inputAttackModifyPP.Clear();
            inputAttackModifyName.Focus();
        }

        private void dataGridViewModifyAttack_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewModifyAttack.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.modifyAttackSelectedIndex = this.dataGridViewModifyAttack.SelectedRows[0].Cells["id"].Value.ToString();
                inputAttackModifyName.Text = this.dataGridViewModifyAttack.SelectedRows[0].Cells["name"].Value.ToString();
                inputAttackModifyDamage.Text = this.dataGridViewModifyAttack.SelectedRows[0].Cells["damage"].Value.ToString();
                inputAttackModifyAccuracy.Text = this.dataGridViewModifyAttack.SelectedRows[0].Cells["accuracy"].Value.ToString();
                inputAttackModifyPP.Text = this.dataGridViewModifyAttack.SelectedRows[0].Cells["powerPoint"].Value.ToString();
                inputAttackModifyType.SelectedValue = this.dataGridViewModifyAttack.SelectedRows[0].Cells["typeId"].Value.ToString();
                attacksErrorProvider.Clear();
            }
        }

        private void modifyAttackButton_Click(object sender, EventArgs e)
        {

            attacksErrorProvider.Clear();
            bool hasErrors = false;
            if (string.IsNullOrWhiteSpace(inputAttackModifyName.Text))
            {
                attacksErrorProvider.SetError(inputAttackModifyName, "Campo obrigatório.");
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackModifyName, "");
            }

            if (string.IsNullOrWhiteSpace(inputAttackModifyDamage.Text) || !int.TryParse(inputAttackModifyDamage.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputAttackModifyDamage.Text) ? "Campo obrigatório." : "Deve ser um número.";
                attacksErrorProvider.SetError(inputAttackModifyDamage, errorMessage);
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackModifyDamage, "");
            }

            if (string.IsNullOrWhiteSpace(inputAttackModifyPP.Text) || !int.TryParse(inputAttackModifyPP.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputAttackModifyPP.Text) ? "Campo obrigatório." : "Deve ser um número.";
                attacksErrorProvider.SetError(inputAttackModifyPP, errorMessage);
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackModifyPP, "");
            }

            if (string.IsNullOrWhiteSpace(inputAttackModifyAccuracy.Text) || !int.TryParse(inputAttackModifyAccuracy.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputAttackModifyAccuracy.Text) ? "Campo obrigatório." : "Deve ser um número.";
                attacksErrorProvider.SetError(inputAttackModifyAccuracy, errorMessage);
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackModifyAccuracy, "");
            }



            if (hasErrors)
                return;
            else
                attacksErrorProvider.Clear();




            try
            {
                try
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@name", System.Data.SqlDbType.NVarChar, inputAttackModifyName.Text),
                        new SqlParameter("@damage", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyDamage.Text)),
                        new SqlParameter("@pp", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyPP.Text)),
                        new SqlParameter("@accuracy", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyAccuracy.Text)),
                        new SqlParameter("@type", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyType.SelectedValue.ToString())),
                        new SqlParameter("@id", System.Data.SqlDbType.NVarChar, Convert.ToInt32(this.modifyAttackSelectedIndex))
                    };
                    sqlService.DMLCommand("UPDATE attack SET name=@name, damage=@damage, power_point=@pp, accuracy=@accuracy, type_id=@type WHERE id=@id", parameters);

                    MessageBox.Show("Tipo Alterado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.ClearFields();
                this.UpdateAttack();
            }
        }

        private void dataGridViewExcludeAttack_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewExcludeAttack.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.deleteAttackSelectedIndex = this.dataGridViewExcludeAttack.SelectedRows[0].Cells["excludeId"].Value.ToString();
            }
        }

        private void buttonExcludeAttack_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@id", System.Data.SqlDbType.NVarChar, this.deleteAttackSelectedIndex)
                    };
                    sqlService.DMLCommand("DELETE FROM attack WHERE id = @id", parameters);
                    MessageBox.Show("Ataque excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error) 
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.UpdateAttack();
            }
        }

        private void searchTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters = { };
                    string sqlQuery = "" +
                        "SELECT attack.id, attack.name as nome, attack.accuracy as precisão, attack.damage as dano, attack.power_point as PP, type.name as tipo, type.id as codigo_tipo " +
                        "FROM attack " +
                        "INNER JOIN type on type.id = attack.type_id ";

                    int filterCount = 0;
                    if(!string.IsNullOrEmpty(inputTypeSearchName.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.name LIKE '%{inputTypeSearchName.Text}%' " : $"AND attack.name LIKE '%{inputTypeSearchName.Text}%' ";
                        filterCount++;
                    }

                    if(!string.IsNullOrEmpty(inputAccuracyLess.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.accuracy < {inputAccuracyLess.Text} " : $"AND attack.accuracy < {inputAccuracyLess.Text} ";
                        filterCount++;
                    }
                    if (!string.IsNullOrEmpty(inputAccuracyGreater.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.accuracy > {inputAccuracyGreater.Text} " : $"AND attack.accuracy > {inputAccuracyGreater.Text} ";
                        filterCount++;
                    }

                    if (!string.IsNullOrEmpty(inputDamageLess.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.damage < {inputDamageLess.Text} " : $"AND attack.damage < {inputDamageLess.Text} ";
                        filterCount++;
                    }
                    if (!string.IsNullOrEmpty(inputDamageGreater.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.damage > {inputDamageGreater.Text} " : $"AND attack.damage > {inputDamageGreater.Text} ";
                        filterCount++;
                    }

                    if (!string.IsNullOrEmpty(inputPPLess.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.power_point < {inputPPLess.Text} " : $"AND attack.power_point < {inputPPLess.Text} ";
                        filterCount++;
                    }
                    if (!string.IsNullOrEmpty(inputPPGreater.Text))
                    {
                        sqlQuery += filterCount == 0 ? $"WHERE attack.power_point > {inputPPGreater.Text} " : $"AND attack.power_point > {inputPPGreater.Text} ";
                        filterCount++;
                    }

                    SqlDataReader reader = sqlService.DQLCommand(
                        sqlQuery, parameters
                    );
                    PokeHandDataSet.attackTypeDataTable dataTable = new PokeHandDataSet.attackTypeDataTable();
                    dataTable.Load(reader);
                    dataGridViewSearchAttack.DataSource = dataTable;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
            }
        }

    }
}

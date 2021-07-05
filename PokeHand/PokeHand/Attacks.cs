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
            // TODO: esta linha de código carrega dados na tabela 'pokeHandDataSet3.attack'. Você pode movê-la ou removê-la conforme necessário.
            this.attackTableAdapter1.Fill(this.pokeHandDataSet3.attack);
            // TODO: esta linha de código carrega dados na tabela 'pokeHandDataSet2.attack'. Você pode movê-la ou removê-la conforme necessário.
            this.attackTableAdapter.Fill(this.pokeHandDataSet2.attack);
            // TODO: This line of code loads data into the 'pokeHandDataSet.attackType' table. You can move, or remove it, as needed.
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);
            // TODO: This line of code loads data into the 'pokeHandDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);

        }

        private void addAttackButton_Click(object sender, EventArgs e)
        {
            attacksErrorProvider.Clear();
            bool hasErrors = false;
            if (string.IsNullOrWhiteSpace(inputAttackAddName.Text))
            {
                attacksErrorProvider.SetError(inputAttackAddName, "Campo obrigatório.");
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackAddName, "");
            }

            if (!string.IsNullOrWhiteSpace(inputAttackAddDamage.Text) && !double.TryParse(inputAttackAddDamage.Text, out _))
            {
                string errorMessage = "Deve ser um double.";
                attacksErrorProvider.SetError(inputAttackAddDamage, errorMessage);
                hasErrors = true;
            }  else
            {
                attacksErrorProvider.SetError(inputAttackAddDamage, "");
            }

            if (!string.IsNullOrWhiteSpace(inputAttackAddPowerPoint.Text) && !int.TryParse(inputAttackAddPowerPoint.Text, out _))
            {
                string errorMessage =  "Deve ser um número.";
                attacksErrorProvider.SetError(inputAttackAddPowerPoint, errorMessage);
                hasErrors = true;
            }
            else
            {
                attacksErrorProvider.SetError(inputAttackAddPowerPoint, "");
            }

            if (!string.IsNullOrWhiteSpace(inputAttackAddAccuracy.Text) && !double.TryParse(inputAttackAddAccuracy.Text, out _))
            {
                string errorMessage = "Deve ser um double.";
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
                List<SqlParameter> defaultValues = new List<SqlParameter>();
                List<string> defaultTables = new List<string>();
                List<string> defaultNames = new List<string>();
                if(!string.IsNullOrWhiteSpace(inputAttackAddDamage.Text))
                {
                    defaultValues.Add(new SqlParameter("@damage", System.Data.SqlDbType.Real, Convert.ToDouble(inputAttackAddAccuracy.Text)));
                    defaultTables.Add("damage");
                    defaultNames.Add("@damage");
                }
                if(!string.IsNullOrWhiteSpace(inputAttackAddPowerPoint.Text))
                {
                    defaultValues.Add(new SqlParameter("@pp", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddPowerPoint.Text)));
                    defaultTables.Add("power_point");
                    defaultNames.Add("@pp");
                }
                if(!string.IsNullOrWhiteSpace(inputAttackAddAccuracy.Text))
                {
                    defaultValues.Add(new SqlParameter("@accuracy", System.Data.SqlDbType.Real, Convert.ToDouble(inputAttackAddAccuracy.Text)));
                    defaultTables.Add("accuracy");
                    defaultNames.Add("@accuracy");
                }

                defaultValues.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar, inputAttackAddName.Text));
                defaultTables.Add("name");
                defaultNames.Add("@name");
                
                defaultValues.Add(new SqlParameter("@typeId", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddType.SelectedValue)));
                defaultTables.Add("type_id");
                defaultNames.Add("@typeId");

                SqlParameter[] parameters = defaultValues.ToArray();

                string query = "INSERT INTO attack (" +
                    String.Join(", ", defaultTables) + ") VALUES (" +
                    String.Join(", ", defaultNames) + ")";

                MessageBox.Show(query, "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlService.DMLCommand(query, parameters);
                MessageBox.Show("Ataque adicionado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error) {
                MessageBox.Show(error.Message, "ERRO",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ClearFilters()
        {
            inputTypeSearchName.Clear();
            inputAccuracyGreater.Clear();
            inputAccuracyLess.Clear();
            inputDamageGreater.Clear();
            inputDamageLess.Clear();
            inputPPGreater.Clear();
            inputPPLess.Clear();
            inputTypeSearchName.Focus();
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

                    MessageBox.Show("Ataque alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Ataque excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    if(string.IsNullOrWhiteSpace(inputTypeSearchName.Text))
                    {
                        inputTypeSearchName.Text = "''";
                    }

                    if(string.IsNullOrWhiteSpace(inputAccuracyLess.Text))
                    {
                        inputAccuracyLess.Text = "0";
                    }
                    if (string.IsNullOrWhiteSpace(inputAccuracyGreater.Text))
                    {
                        inputAccuracyGreater.Text = "2147483647";
                    }

                    if (string.IsNullOrWhiteSpace(inputDamageLess.Text))
                    {
                        inputDamageLess.Text = "0";
                    }
                    if (string.IsNullOrWhiteSpace(inputDamageGreater.Text))
                    {
                        inputDamageGreater.Text = "2147483647";
                    }

                    if (string.IsNullOrWhiteSpace(inputPPLess.Text))
                    {
                        inputPPLess.Text = "0";
                    }
                    if (string.IsNullOrWhiteSpace(inputPPGreater.Text))
                    {
                        inputPPGreater.Text = "2147483647";
                    }

                    SqlDataReader reader = sqlService.DQLCommand(
                        $"EXEC attack_filter @name = {inputTypeSearchName.Text}, @minDamage = {inputDamageLess.Text}, " +
                        $"@maxDamage = {inputDamageGreater.Text}, @minPp = {inputPPLess.Text}, @maxPp = {inputPPGreater.Text}, " +
                        $"@minAccuracy = {inputAccuracyLess.Text}, @maxAccuracy = {inputAccuracyGreater.Text}", parameters
                    );
                    PokeHandDataSet.attackTypeDataTable dataTable = new PokeHandDataSet.attackTypeDataTable();
                    dataTable.Load(reader);
                    dataGridViewSearchAttack.DataSource = dataTable;
                    this.ClearFilters();
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

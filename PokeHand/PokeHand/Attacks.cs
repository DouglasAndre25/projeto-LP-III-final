using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", System.Data.SqlDbType.NVarChar, inputAttackAddName.Text),
                    new SqlParameter("@damage", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddDamage.Text)),
                    new SqlParameter("@pp", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddPowerPoint.Text)),
                    new SqlParameter("@accuracy", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackAddAccuracy.Text)),
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

            }
        }

        private void modifyAttackButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@name", System.Data.SqlDbType.NVarChar, inputAttackModifyName.Text),
                        new SqlParameter("@damage", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyDamage.Text)),
                        new SqlParameter("@pp", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyPP.Text)),
                        new SqlParameter("@accuracy", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyAccuracy.Text)),
                        new SqlParameter("@type", System.Data.SqlDbType.Int, Convert.ToInt32(inputAttackModifyType.SelectedValue)),
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

    }
}

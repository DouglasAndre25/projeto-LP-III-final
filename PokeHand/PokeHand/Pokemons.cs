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

namespace PokeHand
{
    public partial class Pokemons : Form
    {

        private SqlService sqlService;

        public Pokemons()
        {
            InitializeComponent();
            sqlService = new SqlService();
        }

        private void Pokemons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.attackType' table. You can move, or remove it, as needed.
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);

        }

        private void UpdatePokemons()
        {
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);
        }

        private void ClearFields()
        {
            inputPokemonAddName.Clear();
            inputPokemonAddDescription.Clear();
            inputPokemonAddWeight.Clear();
            inputPokemonAddHeight.Clear();
            pokemonAddDataGridView.ClearSelection();
        }

        private void addPokemonButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@name", SqlDbType.NVarChar, inputPokemonAddName.Text),
                        new SqlParameter("@description", SqlDbType.NVarChar, inputPokemonAddDescription.Text),
                        new SqlParameter("@weight", SqlDbType.Real, Convert.ToDouble(inputPokemonAddWeight.Text)),
                        new SqlParameter("@height", SqlDbType.Real, Convert.ToDouble(inputPokemonAddHeight.Text))
                    };
                    sqlService.DMLCommand("INSERT INTO pokemon (name, description, weight, height) VALUES (@name, @description, @weight, @height);", parameters);

                    SqlParameter[] identityParameters = { };
                    SqlDataReader reader = sqlService.DQLCommand(
                        "SELECT @@IDENTITY AS 'Identity';", identityParameters
                    );
                    
                    if(pokemonAddDataGridView.SelectedRows.Count > 0)
                    {
                        reader.Read();
                        string pokemonId = reader["Identity"].ToString();
                        reader.Close();

                        string pokemonAttackSql = $"INSERT INTO attack_pokemon (attack_id, pokemon_id) VALUES";
                    
                        foreach (DataGridViewRow attack in pokemonAddDataGridView.SelectedRows)
                        {
                            pokemonAttackSql += $" ({attack.Cells["typeId"].Value.ToString()}, {pokemonId}),";
                        }

                        pokemonAttackSql = pokemonAttackSql.Remove(pokemonAttackSql.Length - 1, 1) + ";";

                        sqlService.DMLCommand(pokemonAttackSql, identityParameters);
                        MessageBox.Show(pokemonAttackSql);

                    }

                    MessageBox.Show("Pokemon Cadastrado!", "Pokemon",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Pokemon",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.ClearFields();
                this.UpdatePokemons();
            }
        }

        private void Pokemons_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.attackType' table. You can move, or remove it, as needed.
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);

        }

    }
}

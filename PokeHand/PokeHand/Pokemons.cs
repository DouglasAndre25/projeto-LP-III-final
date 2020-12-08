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
        private string modifyPokemonSelectedIndex;
        private string deletePokemonSelectedIndex;

        public Pokemons()
        {
            InitializeComponent();
            sqlService = new SqlService();
        }

        private void Pokemons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.pokemon' table. You can move, or remove it, as needed.
            this.pokemonTableAdapter.Fill(this.pokeHandDataSet.pokemon);
            // TODO: This line of code loads data into the 'pokeHandDataSet.attackType' table. You can move, or remove it, as needed.
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);

        }

        private void UpdatePokemons()
        {
            this.pokemonTableAdapter.Fill(this.pokeHandDataSet.pokemon);
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);
        }

        private void ClearFields()
        {
            inputPokemonAddName.Clear();
            inputPokemonAddDescription.Clear();
            inputPokemonAddWeight.Clear();
            inputPokemonAddHeight.Clear();
            pokemonAddDataGridView.ClearSelection();

            inputPokemonModifyName.Clear();
            inputPokemonModifyDescription.Clear();
            inputPokemonModifyWeight.Clear();
            inputPokemonModifyHeight.Clear();
            pokemonModifyAttacksDataGrid.ClearSelection();
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

        private void deletePokemonGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (this.deletePokemonGridView.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.deletePokemonSelectedIndex = this.deletePokemonGridView.SelectedRows[0].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            }
        }

        private void deletePokemonButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@id", System.Data.SqlDbType.NVarChar, this.deletePokemonSelectedIndex)
                    };
                    sqlService.DMLCommand(
                        "DELETE FROM attack_pokemon WHERE attack_pokemon.pokemon_id = @id; " +
                        "DELETE FROM pokemon WHERE id = @id;", 
                        parameters
                    );

                    MessageBox.Show("Pokemon excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.UpdatePokemons();
            }
        }

        private void pokemonModifyDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (this.pokemonModifyDataGrid.SelectedRows.Count == 0) return;

            try
            {
                try
                {

                    foreach (DataGridViewRow row in pokemonModifyAttacksDataGrid.Rows)
                    {
                        row.Selected = false;
                    }

                    this.modifyPokemonSelectedIndex = this.pokemonModifyDataGrid.SelectedRows[0].Cells["modifyId"].Value.ToString();

                    SqlParameter[] parameters = {
                        new SqlParameter("@id", SqlDbType.Int, this.modifyPokemonSelectedIndex)
                    };
                    SqlDataReader selectedPokemon = sqlService.DQLCommand("SELECT * FROM pokemon WHERE id = @id;", parameters);

                    selectedPokemon.Read();
                    inputPokemonModifyName.Text = selectedPokemon["name"].ToString();
                    inputPokemonModifyDescription.Text = selectedPokemon["description"].ToString();
                    inputPokemonModifyWeight.Text = selectedPokemon["weight"].ToString();
                    inputPokemonModifyHeight.Text = selectedPokemon["height"].ToString();
                    selectedPokemon.Close();

                    SqlDataReader selectedAttacks = sqlService.DQLCommand(
                        "SELECT attack.id FROM attack_pokemon " +
                        "INNER JOIN attack ON attack.id = attack_pokemon.attack_id " +
                        "WHERE attack_pokemon.pokemon_id = @id;",
                        parameters
                    );

                    while(selectedAttacks.Read())
                    {
                        foreach(DataGridViewRow row in pokemonModifyAttacksDataGrid.Rows)
                        {
                            if (row.Cells["modifyAttackId"].Value.ToString() == selectedAttacks["id"].ToString())
                                row.Selected = true;
                        }
                    }
                    selectedAttacks.Close();

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

        private void modifyPokemonButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@id", SqlDbType.Int, Convert.ToInt32(this.modifyPokemonSelectedIndex)),
                        new SqlParameter("@name", SqlDbType.NVarChar, inputPokemonModifyName.Text),
                        new SqlParameter("@description", SqlDbType.NVarChar, inputPokemonModifyDescription.Text),
                        new SqlParameter("@weight", SqlDbType.Real, Convert.ToDouble(inputPokemonModifyWeight.Text)),
                        new SqlParameter("@height", SqlDbType.Real, Convert.ToDouble(inputPokemonModifyHeight.Text))
                    };
                    sqlService.DMLCommand("UPDATE pokemon SET name=@name, description=@description, weight=@weight, height=@height WHERE id=@id;", parameters);

                    SqlParameter[] deleteAttackPokemonParameters =
                    {
                        new SqlParameter("@id", SqlDbType.Int, Convert.ToInt32(this.modifyPokemonSelectedIndex))
                    };
                    sqlService.DMLCommand("DELETE FROM attack_pokemon WHERE attack_pokemon.pokemon_id = @id;", deleteAttackPokemonParameters);


                    if (pokemonModifyAttacksDataGrid.SelectedRows.Count > 0)
                    {
                        SqlParameter[] insertAttackPokemonParameters = { };
                        string pokemonAttackSql = $"INSERT INTO attack_pokemon (attack_id, pokemon_id) VALUES";

                        foreach (DataGridViewRow attack in pokemonModifyAttacksDataGrid.SelectedRows)
                        {
                            pokemonAttackSql += $" ({attack.Cells["modifyAttackId"].Value.ToString()}, {this.modifyPokemonSelectedIndex}),";
                        }

                        pokemonAttackSql = pokemonAttackSql.Remove(pokemonAttackSql.Length - 1, 1) + ";";

                        sqlService.DMLCommand(pokemonAttackSql, insertAttackPokemonParameters);
                    }

                    MessageBox.Show("Pokemon Alterado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message);
                }
            }
            finally
            {
                sqlService.CloseConnection();
                this.UpdatePokemons();
            }
        }

        private void pokemonSearchDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (this.pokemonSearchDataGrid.SelectedRows.Count == 0) return;

            try
            {
                try
                {

                    foreach (DataGridViewRow row in pokemonSearchAttacksDataGrid.Rows)
                    {
                        row.Selected = false;
                    }

                    string pokemonId = pokemonSearchDataGrid.SelectedRows[0].Cells["searchPokemonId"].Value.ToString();

                    SqlParameter[] parameters = {
                        new SqlParameter("@id", SqlDbType.Int, pokemonId)
                    };
                    SqlDataReader selectedPokemon = sqlService.DQLCommand("SELECT * FROM pokemon WHERE id = @id;", parameters);

                    selectedPokemon.Read();
                    inputPokemonSearchName.Text = selectedPokemon["name"].ToString();
                    inputPokemonSearchDescription.Text = selectedPokemon["description"].ToString();
                    inputPokemonSearchWeight.Text = selectedPokemon["weight"].ToString();
                    inputPokemonSearchHeight.Text = selectedPokemon["height"].ToString();
                    selectedPokemon.Close();

                    SqlDataReader selectedAttacks = sqlService.DQLCommand(
                        "SELECT attack.id FROM attack_pokemon " +
                        "INNER JOIN attack ON attack.id = attack_pokemon.attack_id " +
                        "WHERE attack_pokemon.pokemon_id = @id;",
                        parameters
                    );

                    while (selectedAttacks.Read())
                    {
                        foreach (DataGridViewRow row in pokemonSearchAttacksDataGrid.Rows)
                        {
                            if (row.Cells["searchAttackId"].Value.ToString() == selectedAttacks["id"].ToString())
                                row.Selected = true;
                        }
                    }
                    selectedAttacks.Close();

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

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
        }

        private void ModifyProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.pokemon' table. You can move, or remove it, as needed.
            this.pokemonTableAdapter.Fill(this.pokeHandDataSet.pokemon);
            this.VerifyData();

        }

        private void VerifyData()
        {

            try
            {
                try
                {
                    SqlParameter[] parameters = { };

                    SqlDataReader pokemonsReader = sqlService.DQLCommand(
                        "SELECT pokemon.id, trainer_pokemon.level, trainer_pokemon.life " +
                        "FROM trainer_pokemon " +
                        "INNER JOIN pokemon ON pokemon.id = trainer_pokemon.pokemon_id " +
                        "WHERE trainer_pokemon.trainer_id = 1; ",
                        parameters
                    );
                    if(pokemonsReader.HasRows)
                    {
                        pokemonsReader.Read();
                        inputPokemonLevel1.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife1.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid1.Rows)
                        {
                            if(row.Cells["pokemonId1"].Value.ToString() == pokemonsReader["id"].ToString())
                            {
                                row.Selected = true;
                            }
                        }
                        pokemonsReader.Read();
                        inputPokemonLevel2.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife2.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid2.Rows)
                        {
                            if (row.Cells["pokemonId2"].Value.ToString() == pokemonsReader["id"].ToString())
                            {
                                row.Selected = true;
                            }
                        }
                        pokemonsReader.Read();
                        inputPokemonLevel3.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife3.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid3.Rows)
                        {
                            if (row.Cells["pokemonId3"].Value.ToString() == pokemonsReader["id"].ToString())
                            {
                                row.Selected = true;
                            }
                        }
                        pokemonsReader.Read();
                        inputPokemonLevel4.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife4.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid4.Rows)
                        {
                            if (row.Cells["pokemonId4"].Value.ToString() == pokemonsReader["id"].ToString())
                            {
                                row.Selected = true;
                            }
                        }
                        pokemonsReader.Read();
                        inputPokemonLevel5.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife5.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid5.Rows)
                        {
                            if (row.Cells["pokemonId5"].Value.ToString() == pokemonsReader["id"].ToString())
                            {
                                row.Selected = true;
                            }
                        }
                        pokemonsReader.Read();
                        inputPokemonLevel6.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife6.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid6.Rows)
                        {
                            if (row.Cells["pokemonId6"].Value.ToString() == pokemonsReader["id"].ToString())
                            {
                                row.Selected = true;
                            }
                        }
                    }
                    pokemonsReader.Close();


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
                    MessageBox.Show(error.Message + error.StackTrace);
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

        private void pokemonsSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    SqlParameter[] emptyParameters = { };
                    sqlService.DMLCommand("DELETE FROM trainer_pokemon WHERE trainer_id = 1;", emptyParameters);

                    string insertSQL = "INSERT INTO trainer_pokemon (level, life, pokemon_id, trainer_id) VALUES " +
                        $"({inputPokemonLevel1.Text}, {inputPokemonLife1.Text}, {pokemonDataGrid1.SelectedRows[0].Cells["pokemonId1"].Value}, 1), " +
                        $"({inputPokemonLevel2.Text}, {inputPokemonLife2.Text}, {pokemonDataGrid2.SelectedRows[0].Cells["pokemonId2"].Value}, 1), " +
                        $"({inputPokemonLevel3.Text}, {inputPokemonLife3.Text}, {pokemonDataGrid3.SelectedRows[0].Cells["pokemonId3"].Value}, 1), " +
                        $"({inputPokemonLevel4.Text}, {inputPokemonLife4.Text}, {pokemonDataGrid4.SelectedRows[0].Cells["pokemonId4"].Value}, 1), " +
                        $"({inputPokemonLevel5.Text}, {inputPokemonLife5.Text}, {pokemonDataGrid5.SelectedRows[0].Cells["pokemonId5"].Value}, 1), " +
                        $"({inputPokemonLevel6.Text}, {inputPokemonLife6.Text}, {pokemonDataGrid6.SelectedRows[0].Cells["pokemonId6"].Value}, 1);"
                        ;

                    sqlService.DMLCommand(insertSQL, emptyParameters);
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

    }
}

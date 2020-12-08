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
                    if (pokemonsReader.HasRows)
                    {
                        pokemonsReader.Read();
                        inputPokemonLevel1.Text = pokemonsReader["level"].ToString();
                        inputPokemonLife1.Text = pokemonsReader["life"].ToString();
                        foreach (DataGridViewRow row in pokemonDataGrid1.Rows)
                        {
                            if (row.Cells["pokemonId1"].Value.ToString() == pokemonsReader["id"].ToString())
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
                catch (Exception error)
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
            modifyProfileErrorProvider.Clear();
            bool hasErrors = false;
            if (string.IsNullOrWhiteSpace(inputProfileName.Text))
            {
                modifyProfileErrorProvider.SetError(inputProfileName, "Campo obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputProfileName, "");
            }

            if (string.IsNullOrWhiteSpace(inputProfileAge.Text) || !int.TryParse(inputProfileAge.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputProfileAge.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputProfileAge, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputProfileAge, "");
            }

            if (inputProfileVocation.SelectedItems.Count == 0)
            {
                modifyProfileErrorProvider.SetError(inputProfileVocation, "Campo obrigatório.");
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputProfileVocation, "");
            }

            if (hasErrors)
                return;
            else
                modifyProfileErrorProvider.Clear();

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
            modifyProfileErrorProvider.Clear();
            bool hasErrors = false;

            if (string.IsNullOrWhiteSpace(inputPokemonLevel1.Text) || !int.TryParse(inputPokemonLevel1.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLevel1.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLevel1, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLevel1, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLevel2.Text) || !int.TryParse(inputPokemonLevel2.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLevel2.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLevel2, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLevel2, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLevel3.Text) || !int.TryParse(inputPokemonLevel3.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLevel3.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLevel3, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLevel3, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLevel4.Text) || !int.TryParse(inputPokemonLevel4.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLevel4.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLevel4, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLevel4, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLevel5.Text) || !int.TryParse(inputPokemonLevel5.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLevel5.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLevel5, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLevel5, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLevel6.Text) || !int.TryParse(inputPokemonLevel6.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLevel6.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLevel6, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLevel6, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLife1.Text) || !int.TryParse(inputPokemonLife1.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLife1.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLife1, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLife1, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLife2.Text) || !int.TryParse(inputPokemonLife2.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLife2.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLife2, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLife2, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLife3.Text) || !int.TryParse(inputPokemonLife3.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLife3.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLife3, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLife3, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLife4.Text) || !int.TryParse(inputPokemonLife4.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLife4.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLife4, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLife4, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLife5.Text) || !int.TryParse(inputPokemonLife5.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLife5.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLife5, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLife5, "");
            }

            if (string.IsNullOrWhiteSpace(inputPokemonLife6.Text) || !int.TryParse(inputPokemonLife6.Text, out _))
            {
                string errorMessage = string.IsNullOrWhiteSpace(inputPokemonLife6.Text) ? "Campo obrigatório." : "Deve ser um número.";
                modifyProfileErrorProvider.SetError(inputPokemonLife6, errorMessage);
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(inputPokemonLife6, "");
            }

            if(pokemonDataGrid1.SelectedRows.Count == 0)
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid1, "Campo Obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid1, "");
            }

            if (pokemonDataGrid2.SelectedRows.Count == 0)
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid2, "Campo Obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid2, "");
            }

            if (pokemonDataGrid3.SelectedRows.Count == 0)
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid3, "Campo Obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid3, "");
            }

            if (pokemonDataGrid4.SelectedRows.Count == 0)
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid4, "Campo Obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid4, "");
            }

            if (pokemonDataGrid5.SelectedRows.Count == 0)
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid5, "Campo Obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid5, "");
            }

            if (pokemonDataGrid6.SelectedRows.Count == 0)
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid6, "Campo Obrigatório.");
                hasErrors = true;
            }
            else
            {
                modifyProfileErrorProvider.SetError(pokemonDataGrid6, "");
            }

            /**
            var map = new Dictionary<DataGridView, string>();
            map.Add(pokemonDataGrid1, pokemonDataGrid1.SelectedRows[0].Cells["pokemonId1"].Value.ToString());
            map.Add(pokemonDataGrid2, pokemonDataGrid2.SelectedRows[0].Cells["pokemonId2"].Value.ToString());
            map.Add(pokemonDataGrid3, pokemonDataGrid3.SelectedRows[0].Cells["pokemonId3"].Value.ToString());
            map.Add(pokemonDataGrid4, pokemonDataGrid4.SelectedRows[0].Cells["pokemonId4"].Value.ToString());
            map.Add(pokemonDataGrid5, pokemonDataGrid5.SelectedRows[0].Cells["pokemonId5"].Value.ToString());
            map.Add(pokemonDataGrid6, pokemonDataGrid6.SelectedRows[0].Cells["pokemonId6"].Value.ToString());

            foreach(var grid in map)
            {
                foreach(var grid2 in map)
                {
                    if(grid2.Value == grid.Value)
                    {
                        modifyProfileErrorProvider.SetError(grid.Key, "Não selecionar o mesmo pokemon");
                        modifyProfileErrorProvider.SetError(grid2.Key, "Não selecionar o mesmo pokemon");
                    }
                }
            }
            **/

            if (hasErrors)
                return;
            else
                modifyProfileErrorProvider.Clear();

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

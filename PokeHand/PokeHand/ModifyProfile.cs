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


                    SqlDataReader pokemonsReader = sqlService.DQLCommand(
                        "SELECT pokemon.id, trainer_pokemon.level, trainer_pokemon.life " +
                        "FROM trainer_pokemon " +
                        "INNER JOIN pokemon ON pokemon.id = trainer_pokemon.pokemon_id " +
                        "WHERE trainer_pokemon.trainer_id = 1; ",
                        parameters
                    );  
                    pokemonsReader.Close();
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

        private void pokemonsSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    SqlParameter[] emptyParameters = { };
                    sqlService.DMLCommand("DELETE FROM trainer_pokemon WHERE trainer_id = 1;", emptyParameters);

                    string insertSQL = "INSERT INTO trainer_pokemon (level, life, pokemon_id, trainer_id) VALUES";
                    for (int i = 0; i < 6; i++)
                    {
                        // insertSQL += $" ({trainerPokemons[i].getPokemonLevel()}, {trainerPokemons[i].getPokemonLife()}, {trainerPokemons[i].getPokemonId()}, 1),";
                    }
                    insertSQL = insertSQL.Remove(insertSQL.Length - 1, 1) + ";";
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

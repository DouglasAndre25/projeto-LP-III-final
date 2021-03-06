﻿using System;
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
    public partial class ViewProfile : Form
    {
        private SqlService sqlService;

        public ViewProfile()
        {
            InitializeComponent();
            sqlService = new SqlService();
            this.LoadProfile();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.attackType' table. You can move, or remove it, as needed.
            this.attackTypeTableAdapter.Fill(this.pokeHandDataSet.attackType);
            // TODO: This line of code loads data into the 'pokeHandDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.pokeHandDataSet.DataTable1);
        }

        private void LoadProfile()
        {
            try
            {
                try
                {
                    SqlParameter[] parameters = { };
                    SqlDataReader reader = sqlService.DQLCommand("SELECT * FROM get_trainer_data", parameters);

                    if (reader.HasRows)
                    {
                        reader.Read();
                        inputProfileName.Text = reader["name"].ToString();
                        inputProfileAge.Text = reader["age"].ToString();
                        inputProfileVocation.Text = reader["vocation"].ToString();
                        inputProfileNickname.Text = reader["nick_name"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Você ainda não tem perfil populado, recomenda-se ir à tela de modificação primeiro", 
                            "Perfil vazio", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning
                        );
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao carregar o perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlService.CloseConnection();
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

                    string pokemonId = pokemonSearchDataGrid.SelectedRows[0].Cells["pokemonId"].Value.ToString();
                    SqlParameter[] parameters = {
                        new SqlParameter("@id", SqlDbType.Int, pokemonId)
                    };
                    SqlDataReader selectedPokemon = sqlService.DQLCommand("SELECT * FROM pokemon WHERE id = @id;", parameters);

                    selectedPokemon.Read();
                    inputPokemonSearchName.Text = selectedPokemon["name"].ToString();
                    inputPokemonSearchDescription.Text = selectedPokemon["description"].ToString();
                    inputPokemonSearchWeight.Text = selectedPokemon["weight"].ToString();
                    inputPokemonSearchHeight.Text = selectedPokemon["height"].ToString();
                    pokemonDetails.Text = $"Detalhes do Pokemon {selectedPokemon["name"]}";
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

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
    public partial class MainScreen : Form
    {
        private SqlService sqlService;

        public MainScreen()
        {
            InitializeComponent();
            sqlService = new SqlService();
            this.LoadTime();
        }

        private void LoadTime()
        {
            try 
            { 
            
                SqlParameter[] parameters = { };
                SqlDataReader reader = sqlService.DQLCommand("SELECT * FROM get_last_change", parameters);

                if(reader.HasRows)
                {
                    reader.Read();
                    labelUltimaMudanca.Text = reader["create_date"].ToString();
                } else
                {
                    labelUltimaMudanca.Text = "-";
                }
            } 
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Erro ao carregar o perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void typesButton_Click(object sender, EventArgs e) 
        {
            new Types().Show();
        }

        private void attacksButton_Click(object sender, EventArgs e)
        {
            new Attacks().Show();
        }

        private void pokemonsButton_Click(object sender, EventArgs e)
        {
            new Pokemons().Show();
        }

        private void modifyProfileButton_Click(object sender, EventArgs e)
        {
            new ModifyProfile().Show();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            new ViewProfile().Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pokeHandDataSet1.poke_log'. Você pode movê-la ou removê-la conforme necessário.
            this.poke_logTableAdapter.Fill(this.pokeHandDataSet1.poke_log);

        }
    }
}

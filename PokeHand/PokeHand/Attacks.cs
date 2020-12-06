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
        public Attacks()
        {
            InitializeComponent();
        }

        private void Attacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.AttackTypeCustom' table. You can move, or remove it, as needed.
            this.attackTypeCustomAdapter.Fill(this.pokeHandDataSet.AttackTypeCustom);
            // TODO: This line of code loads data into the 'pokeHandDataSet.attack_pokemon' table. You can move, or remove it, as needed.
            this.attack_pokemonTableAdapter.Fill(this.pokeHandDataSet.attack_pokemon);
            // TODO: This line of code loads data into the 'pokeHandDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);
            // TODO: This line of code loads data into the 'pokeHandDataSet.attack' table. You can move, or remove it, as needed.
            this.attackTableAdapter.Fill(this.pokeHandDataSet.attack);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.attackTableAdapter.Fill(this.pokeHandDataSet.attack);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.attackTableAdapter.FillBy(this.pokeHandDataSet.attack);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
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
    }
}

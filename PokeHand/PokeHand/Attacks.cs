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

        public Attacks()
        {
            InitializeComponent();
        }

        private void Attacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokeHandDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.pokeHandDataSet.type);

        }

        private void addAttackButton_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("a");
            }
            finally
            {
                this.sqlService.CloseConnection();
            }
        }
    }
}

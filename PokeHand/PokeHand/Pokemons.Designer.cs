namespace PokeHand
{
    partial class Pokemons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemons));
            this.pokemonsControl = new System.Windows.Forms.TabControl();
            this.searchPokemon = new System.Windows.Forms.TabPage();
            this.addPokemon = new System.Windows.Forms.TabPage();
            this.modifyPokemon = new System.Windows.Forms.TabPage();
            this.deletePokemon = new System.Windows.Forms.TabPage();
            this.pokemonsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokemonsControl
            // 
            this.pokemonsControl.Controls.Add(this.searchPokemon);
            this.pokemonsControl.Controls.Add(this.addPokemon);
            this.pokemonsControl.Controls.Add(this.modifyPokemon);
            this.pokemonsControl.Controls.Add(this.deletePokemon);
            this.pokemonsControl.Location = new System.Drawing.Point(17, 30);
            this.pokemonsControl.Name = "pokemonsControl";
            this.pokemonsControl.SelectedIndex = 0;
            this.pokemonsControl.Size = new System.Drawing.Size(750, 500);
            this.pokemonsControl.TabIndex = 2;
            // 
            // searchPokemon
            // 
            this.searchPokemon.Location = new System.Drawing.Point(4, 22);
            this.searchPokemon.Name = "searchPokemon";
            this.searchPokemon.Padding = new System.Windows.Forms.Padding(3);
            this.searchPokemon.Size = new System.Drawing.Size(742, 474);
            this.searchPokemon.TabIndex = 0;
            this.searchPokemon.Text = "Buscar Pokemon";
            this.searchPokemon.UseVisualStyleBackColor = true;
            // 
            // addPokemon
            // 
            this.addPokemon.Location = new System.Drawing.Point(4, 22);
            this.addPokemon.Name = "addPokemon";
            this.addPokemon.Padding = new System.Windows.Forms.Padding(3);
            this.addPokemon.Size = new System.Drawing.Size(742, 474);
            this.addPokemon.TabIndex = 1;
            this.addPokemon.Text = "Adicionar Pokemon";
            this.addPokemon.UseVisualStyleBackColor = true;
            // 
            // modifyPokemon
            // 
            this.modifyPokemon.Location = new System.Drawing.Point(4, 22);
            this.modifyPokemon.Name = "modifyPokemon";
            this.modifyPokemon.Size = new System.Drawing.Size(742, 474);
            this.modifyPokemon.TabIndex = 2;
            this.modifyPokemon.Text = "Modificar Pokemon";
            this.modifyPokemon.UseVisualStyleBackColor = true;
            // 
            // deletePokemon
            // 
            this.deletePokemon.Location = new System.Drawing.Point(4, 22);
            this.deletePokemon.Name = "deletePokemon";
            this.deletePokemon.Size = new System.Drawing.Size(742, 474);
            this.deletePokemon.TabIndex = 3;
            this.deletePokemon.Text = "Excluir Pokemon";
            this.deletePokemon.UseVisualStyleBackColor = true;
            // 
            // Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pokemonsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pokemons";
            this.Text = "Pokémons";
            this.pokemonsControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pokemonsControl;
        private System.Windows.Forms.TabPage searchPokemon;
        private System.Windows.Forms.TabPage addPokemon;
        private System.Windows.Forms.TabPage modifyPokemon;
        private System.Windows.Forms.TabPage deletePokemon;
    }
}
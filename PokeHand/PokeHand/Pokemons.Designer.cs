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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemons));
            this.pokemonsControl = new System.Windows.Forms.TabControl();
            this.searchPokemon = new System.Windows.Forms.TabPage();
            this.addPokemon = new System.Windows.Forms.TabPage();
            this.addPokemonButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pokemonAddDataGridView = new System.Windows.Forms.DataGridView();
            this.attackTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.inputPokemonAddHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPokemonAddWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPokemonAddDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPokemonAddName = new System.Windows.Forms.TextBox();
            this.labelTypeAddName = new System.Windows.Forms.Label();
            this.modifyPokemon = new System.Windows.Forms.TabPage();
            this.deletePokemon = new System.Windows.Forms.TabPage();
            this.attackTypeTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.attackTypeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokemonsControl.SuspendLayout();
            this.addPokemon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonAddDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
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
            this.addPokemon.Controls.Add(this.addPokemonButton);
            this.addPokemon.Controls.Add(this.groupBox1);
            this.addPokemon.Location = new System.Drawing.Point(4, 22);
            this.addPokemon.Name = "addPokemon";
            this.addPokemon.Padding = new System.Windows.Forms.Padding(3);
            this.addPokemon.Size = new System.Drawing.Size(742, 474);
            this.addPokemon.TabIndex = 1;
            this.addPokemon.Text = "Adicionar Pokemon";
            this.addPokemon.UseVisualStyleBackColor = true;
            // 
            // addPokemonButton
            // 
            this.addPokemonButton.Location = new System.Drawing.Point(23, 349);
            this.addPokemonButton.Name = "addPokemonButton";
            this.addPokemonButton.Size = new System.Drawing.Size(75, 23);
            this.addPokemonButton.TabIndex = 1;
            this.addPokemonButton.Text = "Adicionar";
            this.addPokemonButton.UseVisualStyleBackColor = true;
            this.addPokemonButton.Click += new System.EventHandler(this.addPokemonButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pokemonAddDataGridView);
            this.groupBox1.Controls.Add(this.inputPokemonAddHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputPokemonAddWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputPokemonAddDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputPokemonAddName);
            this.groupBox1.Controls.Add(this.labelTypeAddName);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Pokemon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ataques:";
            // 
            // pokemonAddDataGridView
            // 
            this.pokemonAddDataGridView.AllowUserToAddRows = false;
            this.pokemonAddDataGridView.AllowUserToDeleteRows = false;
            this.pokemonAddDataGridView.AutoGenerateColumns = false;
            this.pokemonAddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokemonAddDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.typeId});
            this.pokemonAddDataGridView.DataSource = this.attackTypeBindingSource;
            this.pokemonAddDataGridView.Location = new System.Drawing.Point(371, 56);
            this.pokemonAddDataGridView.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.pokemonAddDataGridView.Name = "pokemonAddDataGridView";
            this.pokemonAddDataGridView.ReadOnly = true;
            this.pokemonAddDataGridView.Size = new System.Drawing.Size(302, 200);
            this.pokemonAddDataGridView.TabIndex = 10;
            // 
            // attackTypeBindingSource
            // 
            this.attackTypeBindingSource.DataMember = "attackType";
            this.attackTypeBindingSource.DataSource = this.pokeHandDataSet;
            // 
            // pokeHandDataSet
            // 
            this.pokeHandDataSet.DataSetName = "PokeHandDataSet";
            this.pokeHandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputPokemonAddHeight
            // 
            this.inputPokemonAddHeight.Location = new System.Drawing.Point(23, 236);
            this.inputPokemonAddHeight.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.inputPokemonAddHeight.Name = "inputPokemonAddHeight";
            this.inputPokemonAddHeight.Size = new System.Drawing.Size(308, 20);
            this.inputPokemonAddHeight.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Altura:";
            // 
            // inputPokemonAddWeight
            // 
            this.inputPokemonAddWeight.Location = new System.Drawing.Point(23, 176);
            this.inputPokemonAddWeight.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.inputPokemonAddWeight.Name = "inputPokemonAddWeight";
            this.inputPokemonAddWeight.Size = new System.Drawing.Size(308, 20);
            this.inputPokemonAddWeight.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peso:";
            // 
            // inputPokemonAddDescription
            // 
            this.inputPokemonAddDescription.Location = new System.Drawing.Point(23, 116);
            this.inputPokemonAddDescription.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.inputPokemonAddDescription.Name = "inputPokemonAddDescription";
            this.inputPokemonAddDescription.Size = new System.Drawing.Size(308, 20);
            this.inputPokemonAddDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição:";
            // 
            // inputPokemonAddName
            // 
            this.inputPokemonAddName.Location = new System.Drawing.Point(23, 56);
            this.inputPokemonAddName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.inputPokemonAddName.Name = "inputPokemonAddName";
            this.inputPokemonAddName.Size = new System.Drawing.Size(308, 20);
            this.inputPokemonAddName.TabIndex = 2;
            // 
            // labelTypeAddName
            // 
            this.labelTypeAddName.AutoSize = true;
            this.labelTypeAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeAddName.Location = new System.Drawing.Point(23, 36);
            this.labelTypeAddName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelTypeAddName.Name = "labelTypeAddName";
            this.labelTypeAddName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeAddName.TabIndex = 3;
            this.labelTypeAddName.Text = "Nome:";
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
            // attackTypeTableAdapter
            // 
            this.attackTypeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 32;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 120;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 106;
            // 
            // typeId
            // 
            this.typeId.DataPropertyName = "codigo_tipo";
            this.typeId.HeaderText = "codigo_tipo";
            this.typeId.Name = "typeId";
            this.typeId.ReadOnly = true;
            this.typeId.Visible = false;
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
            this.Load += new System.EventHandler(this.Pokemons_Load_1);
            this.pokemonsControl.ResumeLayout(false);
            this.addPokemon.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonAddDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pokemonsControl;
        private System.Windows.Forms.TabPage searchPokemon;
        private System.Windows.Forms.TabPage addPokemon;
        private System.Windows.Forms.TabPage modifyPokemon;
        private System.Windows.Forms.TabPage deletePokemon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputPokemonAddName;
        private System.Windows.Forms.Label labelTypeAddName;
        private System.Windows.Forms.TextBox inputPokemonAddDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView pokemonAddDataGridView;
        private System.Windows.Forms.TextBox inputPokemonAddHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputPokemonAddWeight;
        private System.Windows.Forms.Label label2;
        private PokeHandDataSet pokeHandDataSet;
        private System.Windows.Forms.BindingSource attackTypeBindingSource;
        private PokeHandDataSetTableAdapters.attackTypeTableAdapter attackTypeTableAdapter;
        private System.Windows.Forms.Button addPokemonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeId;
    }
}
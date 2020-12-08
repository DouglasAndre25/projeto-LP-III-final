namespace PokeHand
{
    partial class ViewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputProfileVocation = new System.Windows.Forms.TextBox();
            this.inputProfileAge = new System.Windows.Forms.TextBox();
            this.inputProfileName = new System.Windows.Forms.TextBox();
            this.pokemon = new System.Windows.Forms.GroupBox();
            this.pokemonDetails = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pokemonSearchAttacksDataGrid = new System.Windows.Forms.DataGridView();
            this.searchAttackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precisãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigotipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.inputPokemonSearchHeight = new System.Windows.Forms.TextBox();
            this.inputPokemonSearchWeight = new System.Windows.Forms.TextBox();
            this.inputPokemonSearchDescription = new System.Windows.Forms.TextBox();
            this.inputPokemonSearchName = new System.Windows.Forms.TextBox();
            this.pokemonSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.pokemonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new PokeHand.PokeHandDataSetTableAdapters.DataTable1TableAdapter();
            this.attackTypeTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.attackTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.pokemon.SuspendLayout();
            this.pokemonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSearchAttacksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSearchDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputProfileVocation);
            this.groupBox1.Controls.Add(this.inputProfileAge);
            this.groupBox1.Controls.Add(this.inputProfileName);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meus Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Profissão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // inputProfileVocation
            // 
            this.inputProfileVocation.Location = new System.Drawing.Point(652, 46);
            this.inputProfileVocation.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputProfileVocation.Name = "inputProfileVocation";
            this.inputProfileVocation.ReadOnly = true;
            this.inputProfileVocation.Size = new System.Drawing.Size(295, 20);
            this.inputProfileVocation.TabIndex = 11;
            // 
            // inputProfileAge
            // 
            this.inputProfileAge.Location = new System.Drawing.Point(339, 46);
            this.inputProfileAge.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputProfileAge.Name = "inputProfileAge";
            this.inputProfileAge.ReadOnly = true;
            this.inputProfileAge.Size = new System.Drawing.Size(295, 20);
            this.inputProfileAge.TabIndex = 10;
            // 
            // inputProfileName
            // 
            this.inputProfileName.Location = new System.Drawing.Point(23, 46);
            this.inputProfileName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputProfileName.Name = "inputProfileName";
            this.inputProfileName.ReadOnly = true;
            this.inputProfileName.Size = new System.Drawing.Size(295, 20);
            this.inputProfileName.TabIndex = 2;
            // 
            // pokemon
            // 
            this.pokemon.Controls.Add(this.pokemonDetails);
            this.pokemon.Controls.Add(this.pokemonSearchDataGrid);
            this.pokemon.Location = new System.Drawing.Point(19, 132);
            this.pokemon.Margin = new System.Windows.Forms.Padding(10);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(970, 578);
            this.pokemon.TabIndex = 15;
            this.pokemon.TabStop = false;
            this.pokemon.Text = "Meus Pokémon";
            // 
            // pokemonDetails
            // 
            this.pokemonDetails.Controls.Add(this.label8);
            this.pokemonDetails.Controls.Add(this.label7);
            this.pokemonDetails.Controls.Add(this.label6);
            this.pokemonDetails.Controls.Add(this.label5);
            this.pokemonDetails.Controls.Add(this.label4);
            this.pokemonDetails.Controls.Add(this.pokemonSearchAttacksDataGrid);
            this.pokemonDetails.Controls.Add(this.inputPokemonSearchHeight);
            this.pokemonDetails.Controls.Add(this.inputPokemonSearchWeight);
            this.pokemonDetails.Controls.Add(this.inputPokemonSearchDescription);
            this.pokemonDetails.Controls.Add(this.inputPokemonSearchName);
            this.pokemonDetails.Location = new System.Drawing.Point(23, 318);
            this.pokemonDetails.Margin = new System.Windows.Forms.Padding(20);
            this.pokemonDetails.Name = "pokemonDetails";
            this.pokemonDetails.Size = new System.Drawing.Size(924, 237);
            this.pokemonDetails.TabIndex = 4;
            this.pokemonDetails.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ataques:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome:";
            // 
            // pokemonSearchAttacksDataGrid
            // 
            this.pokemonSearchAttacksDataGrid.AllowUserToAddRows = false;
            this.pokemonSearchAttacksDataGrid.AllowUserToDeleteRows = false;
            this.pokemonSearchAttacksDataGrid.AutoGenerateColumns = false;
            this.pokemonSearchAttacksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokemonSearchAttacksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchAttackId,
            this.nomeDataGridViewTextBoxColumn,
            this.precisãoDataGridViewTextBoxColumn,
            this.danoDataGridViewTextBoxColumn,
            this.pPDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.codigotipoDataGridViewTextBoxColumn});
            this.pokemonSearchAttacksDataGrid.DataSource = this.attackTypeBindingSource;
            this.pokemonSearchAttacksDataGrid.Enabled = false;
            this.pokemonSearchAttacksDataGrid.Location = new System.Drawing.Point(480, 41);
            this.pokemonSearchAttacksDataGrid.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.pokemonSearchAttacksDataGrid.Name = "pokemonSearchAttacksDataGrid";
            this.pokemonSearchAttacksDataGrid.ReadOnly = true;
            this.pokemonSearchAttacksDataGrid.Size = new System.Drawing.Size(421, 175);
            this.pokemonSearchAttacksDataGrid.TabIndex = 10;
            // 
            // searchAttackId
            // 
            this.searchAttackId.DataPropertyName = "id";
            this.searchAttackId.HeaderText = "ID";
            this.searchAttackId.Name = "searchAttackId";
            this.searchAttackId.ReadOnly = true;
            this.searchAttackId.Visible = false;
            this.searchAttackId.Width = 32;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 137;
            // 
            // precisãoDataGridViewTextBoxColumn
            // 
            this.precisãoDataGridViewTextBoxColumn.DataPropertyName = "precisão";
            this.precisãoDataGridViewTextBoxColumn.HeaderText = "Precisão";
            this.precisãoDataGridViewTextBoxColumn.Name = "precisãoDataGridViewTextBoxColumn";
            this.precisãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precisãoDataGridViewTextBoxColumn.Width = 60;
            // 
            // danoDataGridViewTextBoxColumn
            // 
            this.danoDataGridViewTextBoxColumn.DataPropertyName = "dano";
            this.danoDataGridViewTextBoxColumn.HeaderText = "Dano";
            this.danoDataGridViewTextBoxColumn.Name = "danoDataGridViewTextBoxColumn";
            this.danoDataGridViewTextBoxColumn.ReadOnly = true;
            this.danoDataGridViewTextBoxColumn.Width = 60;
            // 
            // pPDataGridViewTextBoxColumn
            // 
            this.pPDataGridViewTextBoxColumn.DataPropertyName = "PP";
            this.pPDataGridViewTextBoxColumn.HeaderText = "PP";
            this.pPDataGridViewTextBoxColumn.Name = "pPDataGridViewTextBoxColumn";
            this.pPDataGridViewTextBoxColumn.ReadOnly = true;
            this.pPDataGridViewTextBoxColumn.Width = 60;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 60;
            // 
            // codigotipoDataGridViewTextBoxColumn
            // 
            this.codigotipoDataGridViewTextBoxColumn.DataPropertyName = "codigo_tipo";
            this.codigotipoDataGridViewTextBoxColumn.HeaderText = "codigo_tipo";
            this.codigotipoDataGridViewTextBoxColumn.Name = "codigotipoDataGridViewTextBoxColumn";
            this.codigotipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigotipoDataGridViewTextBoxColumn.Visible = false;
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
            // inputPokemonSearchHeight
            // 
            this.inputPokemonSearchHeight.Enabled = false;
            this.inputPokemonSearchHeight.Location = new System.Drawing.Point(23, 196);
            this.inputPokemonSearchHeight.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.inputPokemonSearchHeight.Name = "inputPokemonSearchHeight";
            this.inputPokemonSearchHeight.ReadOnly = true;
            this.inputPokemonSearchHeight.Size = new System.Drawing.Size(417, 20);
            this.inputPokemonSearchHeight.TabIndex = 9;
            // 
            // inputPokemonSearchWeight
            // 
            this.inputPokemonSearchWeight.Enabled = false;
            this.inputPokemonSearchWeight.Location = new System.Drawing.Point(23, 146);
            this.inputPokemonSearchWeight.Margin = new System.Windows.Forms.Padding(20, 2, 20, 5);
            this.inputPokemonSearchWeight.Name = "inputPokemonSearchWeight";
            this.inputPokemonSearchWeight.ReadOnly = true;
            this.inputPokemonSearchWeight.Size = new System.Drawing.Size(417, 20);
            this.inputPokemonSearchWeight.TabIndex = 6;
            // 
            // inputPokemonSearchDescription
            // 
            this.inputPokemonSearchDescription.Enabled = false;
            this.inputPokemonSearchDescription.Location = new System.Drawing.Point(23, 91);
            this.inputPokemonSearchDescription.Margin = new System.Windows.Forms.Padding(20, 2, 20, 10);
            this.inputPokemonSearchDescription.Name = "inputPokemonSearchDescription";
            this.inputPokemonSearchDescription.ReadOnly = true;
            this.inputPokemonSearchDescription.Size = new System.Drawing.Size(417, 20);
            this.inputPokemonSearchDescription.TabIndex = 4;
            // 
            // inputPokemonSearchName
            // 
            this.inputPokemonSearchName.Enabled = false;
            this.inputPokemonSearchName.Location = new System.Drawing.Point(23, 41);
            this.inputPokemonSearchName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 5);
            this.inputPokemonSearchName.Name = "inputPokemonSearchName";
            this.inputPokemonSearchName.ReadOnly = true;
            this.inputPokemonSearchName.Size = new System.Drawing.Size(417, 20);
            this.inputPokemonSearchName.TabIndex = 2;
            // 
            // pokemonSearchDataGrid
            // 
            this.pokemonSearchDataGrid.AllowUserToAddRows = false;
            this.pokemonSearchDataGrid.AllowUserToDeleteRows = false;
            this.pokemonSearchDataGrid.AutoGenerateColumns = false;
            this.pokemonSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokemonSearchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pokemonId,
            this.nameDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.lifeDataGridViewTextBoxColumn});
            this.pokemonSearchDataGrid.DataSource = this.dataTable1BindingSource;
            this.pokemonSearchDataGrid.Location = new System.Drawing.Point(23, 36);
            this.pokemonSearchDataGrid.Margin = new System.Windows.Forms.Padding(20);
            this.pokemonSearchDataGrid.MultiSelect = false;
            this.pokemonSearchDataGrid.Name = "pokemonSearchDataGrid";
            this.pokemonSearchDataGrid.ReadOnly = true;
            this.pokemonSearchDataGrid.Size = new System.Drawing.Size(924, 266);
            this.pokemonSearchDataGrid.TabIndex = 3;
            this.pokemonSearchDataGrid.SelectionChanged += new System.EventHandler(this.pokemonSearchDataGrid_SelectionChanged);
            // 
            // pokemonId
            // 
            this.pokemonId.DataPropertyName = "id";
            this.pokemonId.HeaderText = "ID";
            this.pokemonId.Name = "pokemonId";
            this.pokemonId.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 280;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Nível";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn.Width = 250;
            // 
            // lifeDataGridViewTextBoxColumn
            // 
            this.lifeDataGridViewTextBoxColumn.DataPropertyName = "life";
            this.lifeDataGridViewTextBoxColumn.HeaderText = "Vida";
            this.lifeDataGridViewTextBoxColumn.Name = "lifeDataGridViewTextBoxColumn";
            this.lifeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lifeDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.pokeHandDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // attackTypeTableAdapter
            // 
            this.attackTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProfile";
            this.Text = "Ver Perfil";
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pokemon.ResumeLayout(false);
            this.pokemonDetails.ResumeLayout(false);
            this.pokemonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSearchAttacksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSearchDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputProfileVocation;
        private System.Windows.Forms.TextBox inputProfileAge;
        private System.Windows.Forms.TextBox inputProfileName;
        private System.Windows.Forms.GroupBox pokemon;
        private System.Windows.Forms.GroupBox pokemonDetails;
        private System.Windows.Forms.DataGridView pokemonSearchAttacksDataGrid;
        private System.Windows.Forms.TextBox inputPokemonSearchHeight;
        private System.Windows.Forms.TextBox inputPokemonSearchWeight;
        private System.Windows.Forms.TextBox inputPokemonSearchDescription;
        private System.Windows.Forms.TextBox inputPokemonSearchName;
        private PokeHandDataSet pokeHandDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private PokeHandDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource attackTypeBindingSource;
        private PokeHandDataSetTableAdapters.attackTypeTableAdapter attackTypeTableAdapter;
        private System.Windows.Forms.DataGridView pokemonSearchDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokemonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchAttackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precisãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigotipoDataGridViewTextBoxColumn;
    }
}
namespace PokeHand
{
    partial class ModifyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProfile));
            this.teamSubmitButton = new System.Windows.Forms.TabControl();
            this.profileData = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profileSubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputProfileVocation = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputProfileAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputProfileName = new System.Windows.Forms.TextBox();
            this.labelTypeAddName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pokemonsSubmitButton = new System.Windows.Forms.Button();
            this.pokemonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pokemonBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.pokemonBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.pokemonBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pokemonBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pokemonBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pokemonBox1 = new System.Windows.Forms.GroupBox();
            this.pokemonDataGrid1 = new System.Windows.Forms.DataGridView();
            this.pokemonId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokemonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.pokemonTableAdapter();
            this.teamSubmitButton.SuspendLayout();
            this.profileData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pokemonGrid.SuspendLayout();
            this.pokemonBox6.SuspendLayout();
            this.pokemonBox5.SuspendLayout();
            this.pokemonBox4.SuspendLayout();
            this.pokemonBox3.SuspendLayout();
            this.pokemonBox2.SuspendLayout();
            this.pokemonBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teamSubmitButton
            // 
            this.teamSubmitButton.Controls.Add(this.profileData);
            this.teamSubmitButton.Controls.Add(this.tabPage2);
            this.teamSubmitButton.Location = new System.Drawing.Point(19, 19);
            this.teamSubmitButton.Margin = new System.Windows.Forms.Padding(10);
            this.teamSubmitButton.Name = "teamSubmitButton";
            this.teamSubmitButton.SelectedIndex = 0;
            this.teamSubmitButton.Size = new System.Drawing.Size(970, 691);
            this.teamSubmitButton.TabIndex = 0;
            // 
            // profileData
            // 
            this.profileData.Controls.Add(this.groupBox1);
            this.profileData.Location = new System.Drawing.Point(4, 22);
            this.profileData.Name = "profileData";
            this.profileData.Padding = new System.Windows.Forms.Padding(3);
            this.profileData.Size = new System.Drawing.Size(962, 665);
            this.profileData.TabIndex = 0;
            this.profileData.Text = "Dados";
            this.profileData.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profileSubmitButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputProfileVocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputProfileAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputProfileName);
            this.groupBox1.Controls.Add(this.labelTypeAddName);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meus Dados";
            // 
            // profileSubmitButton
            // 
            this.profileSubmitButton.Location = new System.Drawing.Point(13, 146);
            this.profileSubmitButton.Margin = new System.Windows.Forms.Padding(10);
            this.profileSubmitButton.Name = "profileSubmitButton";
            this.profileSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.profileSubmitButton.TabIndex = 1;
            this.profileSubmitButton.Text = "Salvar";
            this.profileSubmitButton.UseVisualStyleBackColor = true;
            this.profileSubmitButton.Click += new System.EventHandler(this.profileSubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profissão:";
            // 
            // inputProfileVocation
            // 
            this.inputProfileVocation.FormattingEnabled = true;
            this.inputProfileVocation.Items.AddRange(new object[] {
            "Treinador Pokémon",
            "Caçador Pokémon",
            "Estilista Pokémon",
            "Pesquisador Pokémon",
            "Pokémon Performer",
            "Especialista Pokémon",
            "Criador Pokémon",
            "Coordenador Pokémon",
            "Líder de Ginásio",
            "Mestre Pokémon",
            "Membro da Elite dos Quatro"});
            this.inputProfileVocation.Location = new System.Drawing.Point(483, 46);
            this.inputProfileVocation.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.inputProfileVocation.Name = "inputProfileVocation";
            this.inputProfileVocation.Size = new System.Drawing.Size(420, 82);
            this.inputProfileVocation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // inputProfileAge
            // 
            this.inputProfileAge.Location = new System.Drawing.Point(13, 106);
            this.inputProfileAge.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.inputProfileAge.Name = "inputProfileAge";
            this.inputProfileAge.Size = new System.Drawing.Size(431, 20);
            this.inputProfileAge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Idade:";
            // 
            // inputProfileName
            // 
            this.inputProfileName.Location = new System.Drawing.Point(13, 46);
            this.inputProfileName.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.inputProfileName.Name = "inputProfileName";
            this.inputProfileName.Size = new System.Drawing.Size(431, 20);
            this.inputProfileName.TabIndex = 2;
            // 
            // labelTypeAddName
            // 
            this.labelTypeAddName.AutoSize = true;
            this.labelTypeAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeAddName.Location = new System.Drawing.Point(13, 26);
            this.labelTypeAddName.Margin = new System.Windows.Forms.Padding(10, 10, 10, 2);
            this.labelTypeAddName.Name = "labelTypeAddName";
            this.labelTypeAddName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeAddName.TabIndex = 3;
            this.labelTypeAddName.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pokemonsSubmitButton);
            this.tabPage2.Controls.Add(this.pokemonGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pokemonsSubmitButton
            // 
            this.pokemonsSubmitButton.Location = new System.Drawing.Point(13, 632);
            this.pokemonsSubmitButton.Margin = new System.Windows.Forms.Padding(10);
            this.pokemonsSubmitButton.Name = "pokemonsSubmitButton";
            this.pokemonsSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.pokemonsSubmitButton.TabIndex = 2;
            this.pokemonsSubmitButton.Text = "Salvar";
            this.pokemonsSubmitButton.UseVisualStyleBackColor = true;
            this.pokemonsSubmitButton.Click += new System.EventHandler(this.pokemonsSubmitButton_Click);
            // 
            // pokemonGrid
            // 
            this.pokemonGrid.ColumnCount = 3;
            this.pokemonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pokemonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.pokemonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.pokemonGrid.Controls.Add(this.pokemonBox6, 2, 1);
            this.pokemonGrid.Controls.Add(this.pokemonBox5, 1, 1);
            this.pokemonGrid.Controls.Add(this.pokemonBox4, 0, 1);
            this.pokemonGrid.Controls.Add(this.pokemonBox3, 2, 0);
            this.pokemonGrid.Controls.Add(this.pokemonBox2, 1, 0);
            this.pokemonGrid.Controls.Add(this.pokemonBox1, 0, 0);
            this.pokemonGrid.Location = new System.Drawing.Point(3, 3);
            this.pokemonGrid.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonGrid.Name = "pokemonGrid";
            this.pokemonGrid.RowCount = 2;
            this.pokemonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.pokemonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pokemonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pokemonGrid.Size = new System.Drawing.Size(956, 613);
            this.pokemonGrid.TabIndex = 0;
            // 
            // pokemonBox6
            // 
            this.pokemonBox6.Controls.Add(this.groupBox13);
            this.pokemonBox6.Location = new System.Drawing.Point(639, 309);
            this.pokemonBox6.Name = "pokemonBox6";
            this.pokemonBox6.Padding = new System.Windows.Forms.Padding(4);
            this.pokemonBox6.Size = new System.Drawing.Size(312, 300);
            this.pokemonBox6.TabIndex = 5;
            this.pokemonBox6.TabStop = false;
            this.pokemonBox6.Text = "Pokemon 6";
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(318, 0);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(312, 300);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "groupBox13";
            // 
            // pokemonBox5
            // 
            this.pokemonBox5.Controls.Add(this.groupBox11);
            this.pokemonBox5.Location = new System.Drawing.Point(321, 309);
            this.pokemonBox5.Name = "pokemonBox5";
            this.pokemonBox5.Padding = new System.Windows.Forms.Padding(4);
            this.pokemonBox5.Size = new System.Drawing.Size(312, 300);
            this.pokemonBox5.TabIndex = 4;
            this.pokemonBox5.TabStop = false;
            this.pokemonBox5.Text = "Pokemon 5";
            // 
            // groupBox11
            // 
            this.groupBox11.Location = new System.Drawing.Point(318, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(312, 300);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "groupBox11";
            // 
            // pokemonBox4
            // 
            this.pokemonBox4.Controls.Add(this.groupBox9);
            this.pokemonBox4.Location = new System.Drawing.Point(3, 309);
            this.pokemonBox4.Name = "pokemonBox4";
            this.pokemonBox4.Padding = new System.Windows.Forms.Padding(4);
            this.pokemonBox4.Size = new System.Drawing.Size(312, 300);
            this.pokemonBox4.TabIndex = 3;
            this.pokemonBox4.TabStop = false;
            this.pokemonBox4.Text = "Pokemon 4";
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(318, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(312, 300);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // pokemonBox3
            // 
            this.pokemonBox3.Controls.Add(this.groupBox7);
            this.pokemonBox3.Location = new System.Drawing.Point(639, 3);
            this.pokemonBox3.Name = "pokemonBox3";
            this.pokemonBox3.Padding = new System.Windows.Forms.Padding(4);
            this.pokemonBox3.Size = new System.Drawing.Size(312, 300);
            this.pokemonBox3.TabIndex = 2;
            this.pokemonBox3.TabStop = false;
            this.pokemonBox3.Text = "Pokemon 3";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(318, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(312, 300);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // pokemonBox2
            // 
            this.pokemonBox2.Controls.Add(this.groupBox5);
            this.pokemonBox2.Location = new System.Drawing.Point(321, 3);
            this.pokemonBox2.Name = "pokemonBox2";
            this.pokemonBox2.Padding = new System.Windows.Forms.Padding(4);
            this.pokemonBox2.Size = new System.Drawing.Size(312, 300);
            this.pokemonBox2.TabIndex = 1;
            this.pokemonBox2.TabStop = false;
            this.pokemonBox2.Text = "Pokemon 2";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(318, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(312, 300);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // pokemonBox1
            // 
            this.pokemonBox1.Controls.Add(this.pokemonDataGrid1);
            this.pokemonBox1.Controls.Add(this.groupBox3);
            this.pokemonBox1.Location = new System.Drawing.Point(3, 3);
            this.pokemonBox1.Name = "pokemonBox1";
            this.pokemonBox1.Padding = new System.Windows.Forms.Padding(4);
            this.pokemonBox1.Size = new System.Drawing.Size(312, 300);
            this.pokemonBox1.TabIndex = 0;
            this.pokemonBox1.TabStop = false;
            this.pokemonBox1.Text = "Pokemon 1";
            // 
            // pokemonDataGrid1
            // 
            this.pokemonDataGrid1.AutoGenerateColumns = false;
            this.pokemonDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokemonDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pokemonId1,
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.pokemonDataGrid1.DataSource = this.pokemonBindingSource1;
            this.pokemonDataGrid1.Location = new System.Drawing.Point(7, 20);
            this.pokemonDataGrid1.MultiSelect = false;
            this.pokemonDataGrid1.Name = "pokemonDataGrid1";
            this.pokemonDataGrid1.Size = new System.Drawing.Size(298, 150);
            this.pokemonDataGrid1.TabIndex = 2;
            // 
            // pokemonId1
            // 
            this.pokemonId1.DataPropertyName = "id";
            this.pokemonId1.HeaderText = "id";
            this.pokemonId1.Name = "pokemonId1";
            this.pokemonId1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // pokemonBindingSource1
            // 
            this.pokemonBindingSource1.DataMember = "pokemon";
            this.pokemonBindingSource1.DataSource = this.pokeHandDataSet;
            // 
            // pokeHandDataSet
            // 
            this.pokeHandDataSet.DataSetName = "PokeHandDataSet";
            this.pokeHandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(318, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(312, 300);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataMember = "pokemon";
            this.pokemonBindingSource.DataSource = this.pokeHandDataSet;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.teamSubmitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyProfile";
            this.Text = "Modificar Perfil";
            this.Load += new System.EventHandler(this.ModifyProfile_Load);
            this.teamSubmitButton.ResumeLayout(false);
            this.profileData.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pokemonGrid.ResumeLayout(false);
            this.pokemonBox6.ResumeLayout(false);
            this.pokemonBox5.ResumeLayout(false);
            this.pokemonBox4.ResumeLayout(false);
            this.pokemonBox3.ResumeLayout(false);
            this.pokemonBox2.ResumeLayout(false);
            this.pokemonBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teamSubmitButton;
        private System.Windows.Forms.TabPage profileData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputProfileAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputProfileName;
        private System.Windows.Forms.Label labelTypeAddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox inputProfileVocation;
        private System.Windows.Forms.Button profileSubmitButton;
        private System.Windows.Forms.TableLayoutPanel pokemonGrid;
        private System.Windows.Forms.Button pokemonsSubmitButton;
        private PokeHandDataSet pokeHandDataSet;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private PokeHandDataSetTableAdapters.pokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.GroupBox pokemonBox1;
        private System.Windows.Forms.GroupBox pokemonBox6;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox pokemonBox5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox pokemonBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox pokemonBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox pokemonBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView pokemonDataGrid1;
        private System.Windows.Forms.BindingSource pokemonBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokemonId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
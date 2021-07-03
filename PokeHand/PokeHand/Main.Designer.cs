namespace PokeHand
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.logoText = new System.Windows.Forms.Label();
            this.mainSection = new System.Windows.Forms.GroupBox();
            this.modifyProfileButton = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.attacksButton = new System.Windows.Forms.Button();
            this.pokemonsButton = new System.Windows.Forms.Button();
            this.dataSection = new System.Windows.Forms.GroupBox();
            this.typesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUltimaMudanca = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet1 = new PokeHand.PokeHandDataSet1();
            this.poke_logTableAdapter = new PokeHand.PokeHandDataSet1TableAdapters.poke_logTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainSection.SuspendLayout();
            this.dataSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokelogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.logoText.Location = new System.Drawing.Point(257, 199);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(253, 39);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "PokeHand v2.0";
            // 
            // mainSection
            // 
            this.mainSection.Controls.Add(this.modifyProfileButton);
            this.mainSection.Controls.Add(this.viewProfileButton);
            this.mainSection.Location = new System.Drawing.Point(214, 251);
            this.mainSection.Name = "mainSection";
            this.mainSection.Size = new System.Drawing.Size(175, 141);
            this.mainSection.TabIndex = 2;
            this.mainSection.TabStop = false;
            this.mainSection.Text = "Perfil";
            // 
            // modifyProfileButton
            // 
            this.modifyProfileButton.Location = new System.Drawing.Point(19, 75);
            this.modifyProfileButton.Name = "modifyProfileButton";
            this.modifyProfileButton.Size = new System.Drawing.Size(136, 29);
            this.modifyProfileButton.TabIndex = 1;
            this.modifyProfileButton.Text = "Modificar Pefil";
            this.modifyProfileButton.UseVisualStyleBackColor = true;
            this.modifyProfileButton.Click += new System.EventHandler(this.modifyProfileButton_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Location = new System.Drawing.Point(19, 40);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(136, 29);
            this.viewProfileButton.TabIndex = 0;
            this.viewProfileButton.Text = "Meu Perfil";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // attacksButton
            // 
            this.attacksButton.Location = new System.Drawing.Point(19, 60);
            this.attacksButton.Name = "attacksButton";
            this.attacksButton.Size = new System.Drawing.Size(136, 29);
            this.attacksButton.TabIndex = 1;
            this.attacksButton.Text = "Ataques";
            this.attacksButton.UseVisualStyleBackColor = true;
            this.attacksButton.Click += new System.EventHandler(this.attacksButton_Click);
            // 
            // pokemonsButton
            // 
            this.pokemonsButton.Location = new System.Drawing.Point(19, 25);
            this.pokemonsButton.Name = "pokemonsButton";
            this.pokemonsButton.Size = new System.Drawing.Size(136, 29);
            this.pokemonsButton.TabIndex = 0;
            this.pokemonsButton.Text = "Pokémons";
            this.pokemonsButton.UseVisualStyleBackColor = true;
            this.pokemonsButton.Click += new System.EventHandler(this.pokemonsButton_Click);
            // 
            // dataSection
            // 
            this.dataSection.Controls.Add(this.typesButton);
            this.dataSection.Controls.Add(this.attacksButton);
            this.dataSection.Controls.Add(this.pokemonsButton);
            this.dataSection.Location = new System.Drawing.Point(395, 251);
            this.dataSection.Name = "dataSection";
            this.dataSection.Size = new System.Drawing.Size(175, 141);
            this.dataSection.TabIndex = 3;
            this.dataSection.TabStop = false;
            this.dataSection.Text = "Dados";
            // 
            // typesButton
            // 
            this.typesButton.Location = new System.Drawing.Point(19, 95);
            this.typesButton.Name = "typesButton";
            this.typesButton.Size = new System.Drawing.Size(136, 29);
            this.typesButton.TabIndex = 2;
            this.typesButton.Text = "Tipos";
            this.typesButton.UseVisualStyleBackColor = true;
            this.typesButton.Click += new System.EventHandler(this.typesButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelUltimaMudanca
            // 
            this.labelUltimaMudanca.AutoSize = true;
            this.labelUltimaMudanca.Location = new System.Drawing.Point(673, 9);
            this.labelUltimaMudanca.Name = "labelUltimaMudanca";
            this.labelUltimaMudanca.Size = new System.Drawing.Size(35, 13);
            this.labelUltimaMudanca.TabIndex = 5;
            this.labelUltimaMudanca.Text = "label1";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(458, 9);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(209, 13);
            this.label90.TabIndex = 6;
            this.label90.Text = "Ultima Modificação feita no horário e data: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pokelogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 116);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 430;
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "Data de Criação";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdateDataGridViewTextBoxColumn.Width = 175;
            // 
            // pokelogBindingSource
            // 
            this.pokelogBindingSource.DataMember = "poke_log";
            this.pokelogBindingSource.DataSource = this.pokeHandDataSet1;
            // 
            // pokeHandDataSet1
            // 
            this.pokeHandDataSet1.DataSetName = "PokeHandDataSet1";
            this.pokeHandDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poke_logTableAdapter
            // 
            this.poke_logTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poke Log";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.labelUltimaMudanca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataSection);
            this.Controls.Add(this.mainSection);
            this.Controls.Add(this.logoText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "PokeHand";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.mainSection.ResumeLayout(false);
            this.dataSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokelogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.GroupBox mainSection;
        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button modifyProfileButton;
        private System.Windows.Forms.Button attacksButton;
        private System.Windows.Forms.Button pokemonsButton;
        private System.Windows.Forms.GroupBox dataSection;
        private System.Windows.Forms.Button typesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUltimaMudanca;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PokeHandDataSet1 pokeHandDataSet1;
        private System.Windows.Forms.BindingSource pokelogBindingSource;
        private PokeHandDataSet1TableAdapters.poke_logTableAdapter poke_logTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


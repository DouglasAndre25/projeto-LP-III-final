﻿namespace PokeHand {
    partial class Types {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Types));
            this.typesControl = new System.Windows.Forms.TabControl();
            this.searchType = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTypeButton = new System.Windows.Forms.Button();
            this.labelTypeSearchName = new System.Windows.Forms.Label();
            this.inputTypeSearchName = new System.Windows.Forms.TextBox();
            this.typeSearchGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addType = new System.Windows.Forms.TabPage();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.labelTypeAddName = new System.Windows.Forms.Label();
            this.inputTypeAddName = new System.Windows.Forms.TextBox();
            this.modifyType = new System.Windows.Forms.TabPage();
            this.typeModifyGridView = new System.Windows.Forms.DataGridView();
            this.typeModifyGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyTypeButton = new System.Windows.Forms.Button();
            this.labelTypeModifyName = new System.Windows.Forms.Label();
            this.inputTypeModifyName = new System.Windows.Forms.TextBox();
            this.deleteType = new System.Windows.Forms.TabPage();
            this.typeDeleteGridView = new System.Windows.Forms.DataGridView();
            this.typeDeleteGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTypeButton = new System.Windows.Forms.Button();
            this.attackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokeHandDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.typeModifyGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDeleteGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.attackTableAdapter();
            this.typeTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.typeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new PokeHand.PokeHandDataSetTableAdapters.DataTable1TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesControl.SuspendLayout();
            this.searchType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeSearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.addType.SuspendLayout();
            this.modifyType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeModifyGridView)).BeginInit();
            this.deleteType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeDeleteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typesControl
            // 
            this.typesControl.Controls.Add(this.searchType);
            this.typesControl.Controls.Add(this.addType);
            this.typesControl.Controls.Add(this.modifyType);
            this.typesControl.Controls.Add(this.deleteType);
            this.typesControl.Location = new System.Drawing.Point(17, 30);
            this.typesControl.Name = "typesControl";
            this.typesControl.SelectedIndex = 0;
            this.typesControl.Size = new System.Drawing.Size(750, 500);
            this.typesControl.TabIndex = 0;
            // 
            // searchType
            // 
            this.searchType.Controls.Add(this.dataGridView1);
            this.searchType.Controls.Add(this.groupBox1);
            this.searchType.Controls.Add(this.typeSearchGridView);
            this.searchType.Location = new System.Drawing.Point(4, 22);
            this.searchType.Name = "searchType";
            this.searchType.Padding = new System.Windows.Forms.Padding(3);
            this.searchType.Size = new System.Drawing.Size(742, 474);
            this.searchType.TabIndex = 0;
            this.searchType.Text = "Buscar Tipo";
            this.searchType.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTypeButton);
            this.groupBox1.Controls.Add(this.labelTypeSearchName);
            this.groupBox1.Controls.Add(this.inputTypeSearchName);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // searchTypeButton
            // 
            this.searchTypeButton.Location = new System.Drawing.Point(409, 37);
            this.searchTypeButton.Name = "searchTypeButton";
            this.searchTypeButton.Size = new System.Drawing.Size(84, 23);
            this.searchTypeButton.TabIndex = 4;
            this.searchTypeButton.Text = "Buscar";
            this.searchTypeButton.UseVisualStyleBackColor = true;
            this.searchTypeButton.Click += new System.EventHandler(this.searchTypeButton_Click);
            // 
            // labelTypeSearchName
            // 
            this.labelTypeSearchName.AutoSize = true;
            this.labelTypeSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeSearchName.Location = new System.Drawing.Point(10, 20);
            this.labelTypeSearchName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelTypeSearchName.Name = "labelTypeSearchName";
            this.labelTypeSearchName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeSearchName.TabIndex = 3;
            this.labelTypeSearchName.Text = "Nome:";
            // 
            // inputTypeSearchName
            // 
            this.inputTypeSearchName.Location = new System.Drawing.Point(10, 40);
            this.inputTypeSearchName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputTypeSearchName.MinimumSize = new System.Drawing.Size(4, 4);
            this.inputTypeSearchName.Name = "inputTypeSearchName";
            this.inputTypeSearchName.Size = new System.Drawing.Size(365, 20);
            this.inputTypeSearchName.TabIndex = 2;
            // 
            // typeSearchGridView
            // 
            this.typeSearchGridView.AllowUserToAddRows = false;
            this.typeSearchGridView.AllowUserToDeleteRows = false;
            this.typeSearchGridView.AllowUserToOrderColumns = true;
            this.typeSearchGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeSearchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.typeSearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeSearchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameDataGridViewTextBoxColumn});
            this.typeSearchGridView.DataSource = this.typeBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typeSearchGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.typeSearchGridView.Location = new System.Drawing.Point(23, 129);
            this.typeSearchGridView.Margin = new System.Windows.Forms.Padding(20);
            this.typeSearchGridView.MultiSelect = false;
            this.typeSearchGridView.Name = "typeSearchGridView";
            this.typeSearchGridView.ReadOnly = true;
            this.typeSearchGridView.Size = new System.Drawing.Size(375, 322);
            this.typeSearchGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 32;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "type";
            this.typeBindingSource.DataSource = this.pokeHandDataSetBindingSource;
            // 
            // addType
            // 
            this.addType.Controls.Add(this.addTypeButton);
            this.addType.Controls.Add(this.labelTypeAddName);
            this.addType.Controls.Add(this.inputTypeAddName);
            this.addType.Location = new System.Drawing.Point(4, 22);
            this.addType.Name = "addType";
            this.addType.Padding = new System.Windows.Forms.Padding(3);
            this.addType.Size = new System.Drawing.Size(742, 474);
            this.addType.TabIndex = 1;
            this.addType.Text = "Adicionar Tipo";
            this.addType.UseVisualStyleBackColor = true;
            // 
            // addTypeButton
            // 
            this.addTypeButton.Location = new System.Drawing.Point(23, 125);
            this.addTypeButton.Margin = new System.Windows.Forms.Padding(20);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(75, 23);
            this.addTypeButton.TabIndex = 2;
            this.addTypeButton.Text = "Adicionar";
            this.addTypeButton.UseVisualStyleBackColor = true;
            this.addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // labelTypeAddName
            // 
            this.labelTypeAddName.AutoSize = true;
            this.labelTypeAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeAddName.Location = new System.Drawing.Point(23, 45);
            this.labelTypeAddName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelTypeAddName.Name = "labelTypeAddName";
            this.labelTypeAddName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeAddName.TabIndex = 1;
            this.labelTypeAddName.Text = "Nome:";
            // 
            // inputTypeAddName
            // 
            this.inputTypeAddName.Location = new System.Drawing.Point(23, 65);
            this.inputTypeAddName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputTypeAddName.Name = "inputTypeAddName";
            this.inputTypeAddName.Size = new System.Drawing.Size(375, 20);
            this.inputTypeAddName.TabIndex = 0;
            // 
            // modifyType
            // 
            this.modifyType.Controls.Add(this.typeModifyGridView);
            this.modifyType.Controls.Add(this.modifyTypeButton);
            this.modifyType.Controls.Add(this.labelTypeModifyName);
            this.modifyType.Controls.Add(this.inputTypeModifyName);
            this.modifyType.Location = new System.Drawing.Point(4, 22);
            this.modifyType.Name = "modifyType";
            this.modifyType.Size = new System.Drawing.Size(742, 474);
            this.modifyType.TabIndex = 2;
            this.modifyType.Text = "Modificar Tipo";
            this.modifyType.UseVisualStyleBackColor = true;
            // 
            // typeModifyGridView
            // 
            this.typeModifyGridView.AllowUserToAddRows = false;
            this.typeModifyGridView.AllowUserToDeleteRows = false;
            this.typeModifyGridView.AllowUserToOrderColumns = true;
            this.typeModifyGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeModifyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.typeModifyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeModifyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeModifyGridViewId,
            this.typeModifyGridViewName});
            this.typeModifyGridView.DataSource = this.typeBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typeModifyGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.typeModifyGridView.Location = new System.Drawing.Point(20, 20);
            this.typeModifyGridView.Margin = new System.Windows.Forms.Padding(20);
            this.typeModifyGridView.MultiSelect = false;
            this.typeModifyGridView.Name = "typeModifyGridView";
            this.typeModifyGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeModifyGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.typeModifyGridView.Size = new System.Drawing.Size(375, 259);
            this.typeModifyGridView.TabIndex = 6;
            this.typeModifyGridView.SelectionChanged += new System.EventHandler(this.typeModifyGridView_SelectionChanged);
            // 
            // typeModifyGridViewId
            // 
            this.typeModifyGridViewId.DataPropertyName = "id";
            this.typeModifyGridViewId.HeaderText = "id";
            this.typeModifyGridViewId.MinimumWidth = 32;
            this.typeModifyGridViewId.Name = "typeModifyGridViewId";
            this.typeModifyGridViewId.ReadOnly = true;
            this.typeModifyGridViewId.Width = 32;
            // 
            // modifyTypeButton
            // 
            this.modifyTypeButton.Location = new System.Drawing.Point(20, 399);
            this.modifyTypeButton.Margin = new System.Windows.Forms.Padding(20);
            this.modifyTypeButton.Name = "modifyTypeButton";
            this.modifyTypeButton.Size = new System.Drawing.Size(75, 23);
            this.modifyTypeButton.TabIndex = 5;
            this.modifyTypeButton.Text = "Modificar";
            this.modifyTypeButton.UseVisualStyleBackColor = true;
            this.modifyTypeButton.Click += new System.EventHandler(this.modifyTypeButton_Click);
            // 
            // labelTypeModifyName
            // 
            this.labelTypeModifyName.AutoSize = true;
            this.labelTypeModifyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeModifyName.Location = new System.Drawing.Point(20, 319);
            this.labelTypeModifyName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelTypeModifyName.Name = "labelTypeModifyName";
            this.labelTypeModifyName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeModifyName.TabIndex = 4;
            this.labelTypeModifyName.Text = "Nome:";
            // 
            // inputTypeModifyName
            // 
            this.inputTypeModifyName.Location = new System.Drawing.Point(20, 339);
            this.inputTypeModifyName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputTypeModifyName.Name = "inputTypeModifyName";
            this.inputTypeModifyName.Size = new System.Drawing.Size(375, 20);
            this.inputTypeModifyName.TabIndex = 3;
            // 
            // deleteType
            // 
            this.deleteType.Controls.Add(this.typeDeleteGridView);
            this.deleteType.Controls.Add(this.deleteTypeButton);
            this.deleteType.Location = new System.Drawing.Point(4, 22);
            this.deleteType.Name = "deleteType";
            this.deleteType.Size = new System.Drawing.Size(742, 474);
            this.deleteType.TabIndex = 3;
            this.deleteType.Text = "Excluir Tipo";
            this.deleteType.UseVisualStyleBackColor = true;
            // 
            // typeDeleteGridView
            // 
            this.typeDeleteGridView.AllowUserToAddRows = false;
            this.typeDeleteGridView.AllowUserToDeleteRows = false;
            this.typeDeleteGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDeleteGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.typeDeleteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDeleteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDeleteGridViewId,
            this.typeDeleteGridViewName});
            this.typeDeleteGridView.DataSource = this.typeBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typeDeleteGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.typeDeleteGridView.Location = new System.Drawing.Point(20, 20);
            this.typeDeleteGridView.Margin = new System.Windows.Forms.Padding(20);
            this.typeDeleteGridView.MultiSelect = false;
            this.typeDeleteGridView.Name = "typeDeleteGridView";
            this.typeDeleteGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDeleteGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.typeDeleteGridView.Size = new System.Drawing.Size(375, 365);
            this.typeDeleteGridView.TabIndex = 10;
            this.typeDeleteGridView.SelectionChanged += new System.EventHandler(this.typeDeleteGridView_SelectionChanged);
            // 
            // typeDeleteGridViewId
            // 
            this.typeDeleteGridViewId.DataPropertyName = "id";
            this.typeDeleteGridViewId.HeaderText = "id";
            this.typeDeleteGridViewId.Name = "typeDeleteGridViewId";
            this.typeDeleteGridViewId.ReadOnly = true;
            this.typeDeleteGridViewId.Width = 32;
            // 
            // deleteTypeButton
            // 
            this.deleteTypeButton.Location = new System.Drawing.Point(20, 425);
            this.deleteTypeButton.Margin = new System.Windows.Forms.Padding(20);
            this.deleteTypeButton.Name = "deleteTypeButton";
            this.deleteTypeButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTypeButton.TabIndex = 9;
            this.deleteTypeButton.Text = "Excluir";
            this.deleteTypeButton.UseVisualStyleBackColor = true;
            this.deleteTypeButton.Click += new System.EventHandler(this.deleteTypeButton_Click);
            // 
            // attackBindingSource
            // 
            this.attackBindingSource.DataMember = "attack";
            this.attackBindingSource.DataSource = this.pokeHandDataSetBindingSource;
            // 
            // typeErrorProvider
            // 
            this.typeErrorProvider.ContainerControl = this;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // pokeHandDataSetBindingSource
            // 
            this.pokeHandDataSetBindingSource.DataSource = this.pokeHandDataSet;
            this.pokeHandDataSetBindingSource.Position = 0;
            // 
            // pokeHandDataSet
            // 
            this.pokeHandDataSet.DataSetName = "PokeHandDataSet";
            this.pokeHandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeModifyGridViewName
            // 
            this.typeModifyGridViewName.DataPropertyName = "name";
            this.typeModifyGridViewName.HeaderText = "name";
            this.typeModifyGridViewName.Name = "typeModifyGridViewName";
            this.typeModifyGridViewName.ReadOnly = true;
            this.typeModifyGridViewName.Width = 300;
            // 
            // typeDeleteGridViewName
            // 
            this.typeDeleteGridViewName.DataPropertyName = "name";
            this.typeDeleteGridViewName.HeaderText = "name";
            this.typeDeleteGridViewName.Name = "typeDeleteGridViewName";
            this.typeDeleteGridViewName.ReadOnly = true;
            this.typeDeleteGridViewName.Width = 300;
            // 
            // attackTableAdapter
            // 
            this.attackTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.type,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(412, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(375, 322);
            this.dataGridView1.TabIndex = 2;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 32;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 561);
            this.Controls.Add(this.typesControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Types";
            this.Text = "Tipos";
            this.Load += new System.EventHandler(this.Types_Load);
            this.typesControl.ResumeLayout(false);
            this.searchType.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeSearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.addType.ResumeLayout(false);
            this.addType.PerformLayout();
            this.modifyType.ResumeLayout(false);
            this.modifyType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeModifyGridView)).EndInit();
            this.deleteType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeDeleteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl typesControl;
        private System.Windows.Forms.TabPage searchType;
        private System.Windows.Forms.TabPage addType;
        private System.Windows.Forms.TabPage modifyType;
        private System.Windows.Forms.TabPage deleteType;
        private System.Windows.Forms.DataGridView typeSearchGridView;
        private System.Windows.Forms.BindingSource pokeHandDataSetBindingSource;
        private PokeHandDataSet pokeHandDataSet;
        private System.Windows.Forms.BindingSource attackBindingSource;
        private PokeHandDataSetTableAdapters.attackTableAdapter attackTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private PokeHandDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Label labelTypeAddName;
        private System.Windows.Forms.TextBox inputTypeAddName;
        private System.Windows.Forms.Button addTypeButton;
        private System.Windows.Forms.Button modifyTypeButton;
        private System.Windows.Forms.Label labelTypeModifyName;
        private System.Windows.Forms.TextBox inputTypeModifyName;
        private System.Windows.Forms.DataGridView typeModifyGridView;
        private System.Windows.Forms.DataGridView typeDeleteGridView;
        private System.Windows.Forms.Button deleteTypeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTypeSearchName;
        private System.Windows.Forms.TextBox inputTypeSearchName;
        private System.Windows.Forms.Button searchTypeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeModifyGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeModifyGridViewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDeleteGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDeleteGridViewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider typeErrorProvider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private PokeHandDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
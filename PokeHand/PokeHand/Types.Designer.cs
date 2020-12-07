namespace PokeHand {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Types));
            this.typesControl = new System.Windows.Forms.TabControl();
            this.searchType = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTypeButton = new System.Windows.Forms.Button();
            this.labelTypeSearchName = new System.Windows.Forms.Label();
            this.inputTypeSearchName = new System.Windows.Forms.TextBox();
            this.typeSearchGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.addType = new System.Windows.Forms.TabPage();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputTypeAddName = new System.Windows.Forms.TextBox();
            this.labelTypeAddName = new System.Windows.Forms.Label();
            this.modifyType = new System.Windows.Forms.TabPage();
            this.typeModifyGridView = new System.Windows.Forms.DataGridView();
            this.typeModifyGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeModifyGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyTypeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputTypeModifyName = new System.Windows.Forms.TextBox();
            this.labelTypeModifyName = new System.Windows.Forms.Label();
            this.deleteType = new System.Windows.Forms.TabPage();
            this.typeDeleteGridView = new System.Windows.Forms.DataGridView();
            this.typeDeleteGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDeleteGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTypeButton = new System.Windows.Forms.Button();
            this.attackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attackTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.attackTableAdapter();
            this.typeTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.typeTableAdapter();
            this.typeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.typesControl.SuspendLayout();
            this.searchType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeSearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
            this.addType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.modifyType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeModifyGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.deleteType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeDeleteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeErrorProvider)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeSearchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.typeSearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeSearchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameDataGridViewTextBoxColumn});
            this.typeSearchGridView.DataSource = this.typeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typeSearchGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.typeSearchGridView.Location = new System.Drawing.Point(20, 129);
            this.typeSearchGridView.Margin = new System.Windows.Forms.Padding(20);
            this.typeSearchGridView.MultiSelect = false;
            this.typeSearchGridView.Name = "typeSearchGridView";
            this.typeSearchGridView.ReadOnly = true;
            this.typeSearchGridView.Size = new System.Drawing.Size(702, 322);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 626;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "type";
            this.typeBindingSource.DataSource = this.pokeHandDataSetBindingSource;
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
            // addType
            // 
            this.addType.Controls.Add(this.addTypeButton);
            this.addType.Controls.Add(this.groupBox2);
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
            this.addTypeButton.Location = new System.Drawing.Point(20, 142);
            this.addTypeButton.Margin = new System.Windows.Forms.Padding(20);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(75, 23);
            this.addTypeButton.TabIndex = 2;
            this.addTypeButton.Text = "Adicionar";
            this.addTypeButton.UseVisualStyleBackColor = true;
            this.addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputTypeAddName);
            this.groupBox2.Controls.Add(this.labelTypeAddName);
            this.groupBox2.Location = new System.Drawing.Point(23, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Tipo";
            // 
            // inputTypeAddName
            // 
            this.inputTypeAddName.Location = new System.Drawing.Point(10, 45);
            this.inputTypeAddName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputTypeAddName.Name = "inputTypeAddName";
            this.inputTypeAddName.Size = new System.Drawing.Size(663, 20);
            this.inputTypeAddName.TabIndex = 0;
            // 
            // labelTypeAddName
            // 
            this.labelTypeAddName.AutoSize = true;
            this.labelTypeAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeAddName.Location = new System.Drawing.Point(10, 25);
            this.labelTypeAddName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelTypeAddName.Name = "labelTypeAddName";
            this.labelTypeAddName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeAddName.TabIndex = 1;
            this.labelTypeAddName.Text = "Nome:";
            // 
            // modifyType
            // 
            this.modifyType.Controls.Add(this.typeModifyGridView);
            this.modifyType.Controls.Add(this.modifyTypeButton);
            this.modifyType.Controls.Add(this.groupBox3);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeModifyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.typeModifyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeModifyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeModifyGridViewId,
            this.typeModifyGridViewName});
            this.typeModifyGridView.DataSource = this.typeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typeModifyGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.typeModifyGridView.Location = new System.Drawing.Point(20, 20);
            this.typeModifyGridView.Margin = new System.Windows.Forms.Padding(20);
            this.typeModifyGridView.MultiSelect = false;
            this.typeModifyGridView.Name = "typeModifyGridView";
            this.typeModifyGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeModifyGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.typeModifyGridView.Size = new System.Drawing.Size(702, 259);
            this.typeModifyGridView.TabIndex = 6;
            this.typeModifyGridView.SelectionChanged += new System.EventHandler(this.typeModifyGridView_SelectionChanged);
            // 
            // typeModifyGridViewId
            // 
            this.typeModifyGridViewId.DataPropertyName = "id";
            this.typeModifyGridViewId.HeaderText = "ID";
            this.typeModifyGridViewId.MinimumWidth = 32;
            this.typeModifyGridViewId.Name = "typeModifyGridViewId";
            this.typeModifyGridViewId.ReadOnly = true;
            this.typeModifyGridViewId.Width = 32;
            // 
            // typeModifyGridViewName
            // 
            this.typeModifyGridViewName.DataPropertyName = "name";
            this.typeModifyGridViewName.HeaderText = "Nome";
            this.typeModifyGridViewName.Name = "typeModifyGridViewName";
            this.typeModifyGridViewName.ReadOnly = true;
            this.typeModifyGridViewName.Width = 626;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputTypeModifyName);
            this.groupBox3.Controls.Add(this.labelTypeModifyName);
            this.groupBox3.Location = new System.Drawing.Point(20, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(702, 82);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Selecionado";
            // 
            // inputTypeModifyName
            // 
            this.inputTypeModifyName.Location = new System.Drawing.Point(13, 39);
            this.inputTypeModifyName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputTypeModifyName.Name = "inputTypeModifyName";
            this.inputTypeModifyName.Size = new System.Drawing.Size(666, 20);
            this.inputTypeModifyName.TabIndex = 3;
            // 
            // labelTypeModifyName
            // 
            this.labelTypeModifyName.AutoSize = true;
            this.labelTypeModifyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeModifyName.Location = new System.Drawing.Point(13, 19);
            this.labelTypeModifyName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelTypeModifyName.Name = "labelTypeModifyName";
            this.labelTypeModifyName.Size = new System.Drawing.Size(48, 16);
            this.labelTypeModifyName.TabIndex = 4;
            this.labelTypeModifyName.Text = "Nome:";
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDeleteGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.typeDeleteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDeleteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDeleteGridViewId,
            this.typeDeleteGridViewName});
            this.typeDeleteGridView.DataSource = this.typeBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typeDeleteGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.typeDeleteGridView.Location = new System.Drawing.Point(20, 20);
            this.typeDeleteGridView.Margin = new System.Windows.Forms.Padding(20);
            this.typeDeleteGridView.MultiSelect = false;
            this.typeDeleteGridView.Name = "typeDeleteGridView";
            this.typeDeleteGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDeleteGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.typeDeleteGridView.Size = new System.Drawing.Size(702, 365);
            this.typeDeleteGridView.TabIndex = 10;
            this.typeDeleteGridView.SelectionChanged += new System.EventHandler(this.typeDeleteGridView_SelectionChanged);
            // 
            // typeDeleteGridViewId
            // 
            this.typeDeleteGridViewId.DataPropertyName = "id";
            this.typeDeleteGridViewId.HeaderText = "ID";
            this.typeDeleteGridViewId.Name = "typeDeleteGridViewId";
            this.typeDeleteGridViewId.ReadOnly = true;
            this.typeDeleteGridViewId.Width = 32;
            // 
            // typeDeleteGridViewName
            // 
            this.typeDeleteGridViewName.DataPropertyName = "name";
            this.typeDeleteGridViewName.HeaderText = "Nome";
            this.typeDeleteGridViewName.Name = "typeDeleteGridViewName";
            this.typeDeleteGridViewName.ReadOnly = true;
            this.typeDeleteGridViewName.Width = 626;
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
            // attackTableAdapter
            // 
            this.attackTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // typeErrorProvider
            // 
            this.typeErrorProvider.ContainerControl = this;
            // 
            // Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).EndInit();
            this.addType.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.modifyType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeModifyGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.deleteType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeDeleteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeErrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider typeErrorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeModifyGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeModifyGridViewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDeleteGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDeleteGridViewName;
    }
}
namespace PokeHand
{
    partial class Attacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attacks));
            this.attacksControl = new System.Windows.Forms.TabControl();
            this.searchAttack = new System.Windows.Forms.TabPage();
            this.addAttack = new System.Windows.Forms.TabPage();
            this.buttonAttackAddSave = new System.Windows.Forms.Button();
            this.listBoxAttackAddType = new System.Windows.Forms.ListBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.inputAttackAddPrecision = new System.Windows.Forms.TextBox();
            this.inputAttackAddPP = new System.Windows.Forms.TextBox();
            this.inputAttackAddDamage = new System.Windows.Forms.TextBox();
            this.inputAttackAddName = new System.Windows.Forms.TextBox();
            this.labelAttackAddType = new System.Windows.Forms.Label();
            this.labelAttackAddPrecision = new System.Windows.Forms.Label();
            this.labelAttackAddPP = new System.Windows.Forms.Label();
            this.labelAttackAddDamage = new System.Windows.Forms.Label();
            this.labelAttackAddName = new System.Windows.Forms.Label();
            this.modifyAttack = new System.Windows.Forms.TabPage();
            this.attackTypeCustomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteAttack = new System.Windows.Forms.TabPage();
            this.attackBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.attackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attackTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.attackTableAdapter();
            this.typeTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.typeTableAdapter();
            this.attackBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attackBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.attackTypeCustomAdapter = new PokeHand.PokeHandDataSetTableAdapters.AttackTypeCustomAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputAttackModifyType = new System.Windows.Forms.ListBox();
            this.inputAttackModifyPrecision = new System.Windows.Forms.TextBox();
            this.inputAttackModifyPP = new System.Windows.Forms.TextBox();
            this.inputAttackModifyDamage = new System.Windows.Forms.TextBox();
            this.inputAttackModifyName = new System.Windows.Forms.TextBox();
            this.labelAttackModifyType = new System.Windows.Forms.Label();
            this.labelAttackModifyPrecision = new System.Windows.Forms.Label();
            this.labelAttackModifyPP = new System.Windows.Forms.Label();
            this.labelAttackModifyDamage = new System.Windows.Forms.Label();
            this.labelAttackModifyName = new System.Windows.Forms.Label();
            this.attacksControl.SuspendLayout();
            this.addAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
            this.modifyAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackTypeCustomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // attacksControl
            // 
            this.attacksControl.Controls.Add(this.searchAttack);
            this.attacksControl.Controls.Add(this.addAttack);
            this.attacksControl.Controls.Add(this.modifyAttack);
            this.attacksControl.Controls.Add(this.deleteAttack);
            this.attacksControl.Location = new System.Drawing.Point(17, 30);
            this.attacksControl.Name = "attacksControl";
            this.attacksControl.SelectedIndex = 0;
            this.attacksControl.Size = new System.Drawing.Size(750, 500);
            this.attacksControl.TabIndex = 1;
            // 
            // searchAttack
            // 
            this.searchAttack.Location = new System.Drawing.Point(4, 22);
            this.searchAttack.Name = "searchAttack";
            this.searchAttack.Padding = new System.Windows.Forms.Padding(3);
            this.searchAttack.Size = new System.Drawing.Size(742, 474);
            this.searchAttack.TabIndex = 0;
            this.searchAttack.Text = "Buscar Ataque";
            this.searchAttack.UseVisualStyleBackColor = true;
            // 
            // addAttack
            // 
            this.addAttack.Controls.Add(this.buttonAttackAddSave);
            this.addAttack.Controls.Add(this.listBoxAttackAddType);
            this.addAttack.Controls.Add(this.inputAttackAddPrecision);
            this.addAttack.Controls.Add(this.inputAttackAddPP);
            this.addAttack.Controls.Add(this.inputAttackAddDamage);
            this.addAttack.Controls.Add(this.inputAttackAddName);
            this.addAttack.Controls.Add(this.labelAttackAddType);
            this.addAttack.Controls.Add(this.labelAttackAddPrecision);
            this.addAttack.Controls.Add(this.labelAttackAddPP);
            this.addAttack.Controls.Add(this.labelAttackAddDamage);
            this.addAttack.Controls.Add(this.labelAttackAddName);
            this.addAttack.Location = new System.Drawing.Point(4, 22);
            this.addAttack.Name = "addAttack";
            this.addAttack.Padding = new System.Windows.Forms.Padding(3);
            this.addAttack.Size = new System.Drawing.Size(742, 474);
            this.addAttack.TabIndex = 1;
            this.addAttack.Text = "Adicionar Ataque";
            this.addAttack.UseVisualStyleBackColor = true;
            // 
            // buttonAttackAddSave
            // 
            this.buttonAttackAddSave.Location = new System.Drawing.Point(581, 227);
            this.buttonAttackAddSave.Name = "buttonAttackAddSave";
            this.buttonAttackAddSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackAddSave.TabIndex = 10;
            this.buttonAttackAddSave.Text = "Salvar";
            this.buttonAttackAddSave.UseVisualStyleBackColor = true;
            // 
            // listBoxAttackAddType
            // 
            this.listBoxAttackAddType.DataSource = this.typeBindingSource;
            this.listBoxAttackAddType.DisplayMember = "name";
            this.listBoxAttackAddType.FormattingEnabled = true;
            this.listBoxAttackAddType.Location = new System.Drawing.Point(426, 79);
            this.listBoxAttackAddType.Name = "listBoxAttackAddType";
            this.listBoxAttackAddType.Size = new System.Drawing.Size(120, 95);
            this.listBoxAttackAddType.TabIndex = 9;
            this.listBoxAttackAddType.ValueMember = "id";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "type";
            this.typeBindingSource.DataSource = this.pokeHandDataSet;
            // 
            // pokeHandDataSet
            // 
            this.pokeHandDataSet.DataSetName = "PokeHandDataSet";
            this.pokeHandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputAttackAddPrecision
            // 
            this.inputAttackAddPrecision.Location = new System.Drawing.Point(224, 79);
            this.inputAttackAddPrecision.Name = "inputAttackAddPrecision";
            this.inputAttackAddPrecision.Size = new System.Drawing.Size(100, 20);
            this.inputAttackAddPrecision.TabIndex = 8;
            // 
            // inputAttackAddPP
            // 
            this.inputAttackAddPP.Location = new System.Drawing.Point(46, 79);
            this.inputAttackAddPP.Name = "inputAttackAddPP";
            this.inputAttackAddPP.Size = new System.Drawing.Size(100, 20);
            this.inputAttackAddPP.TabIndex = 7;
            // 
            // inputAttackAddDamage
            // 
            this.inputAttackAddDamage.Location = new System.Drawing.Point(415, 22);
            this.inputAttackAddDamage.Name = "inputAttackAddDamage";
            this.inputAttackAddDamage.Size = new System.Drawing.Size(241, 20);
            this.inputAttackAddDamage.TabIndex = 6;
            // 
            // inputAttackAddName
            // 
            this.inputAttackAddName.Location = new System.Drawing.Point(60, 22);
            this.inputAttackAddName.Name = "inputAttackAddName";
            this.inputAttackAddName.Size = new System.Drawing.Size(264, 20);
            this.inputAttackAddName.TabIndex = 5;
            // 
            // labelAttackAddType
            // 
            this.labelAttackAddType.AutoSize = true;
            this.labelAttackAddType.Location = new System.Drawing.Point(373, 82);
            this.labelAttackAddType.Name = "labelAttackAddType";
            this.labelAttackAddType.Size = new System.Drawing.Size(31, 13);
            this.labelAttackAddType.TabIndex = 4;
            this.labelAttackAddType.Text = "Tipo:";
            // 
            // labelAttackAddPrecision
            // 
            this.labelAttackAddPrecision.AutoSize = true;
            this.labelAttackAddPrecision.Location = new System.Drawing.Point(167, 82);
            this.labelAttackAddPrecision.Name = "labelAttackAddPrecision";
            this.labelAttackAddPrecision.Size = new System.Drawing.Size(51, 13);
            this.labelAttackAddPrecision.TabIndex = 3;
            this.labelAttackAddPrecision.Text = "Precisão:";
            // 
            // labelAttackAddPP
            // 
            this.labelAttackAddPP.AutoSize = true;
            this.labelAttackAddPP.Location = new System.Drawing.Point(16, 82);
            this.labelAttackAddPP.Name = "labelAttackAddPP";
            this.labelAttackAddPP.Size = new System.Drawing.Size(24, 13);
            this.labelAttackAddPP.TabIndex = 2;
            this.labelAttackAddPP.Text = "PP:";
            // 
            // labelAttackAddDamage
            // 
            this.labelAttackAddDamage.AutoSize = true;
            this.labelAttackAddDamage.Location = new System.Drawing.Point(373, 29);
            this.labelAttackAddDamage.Name = "labelAttackAddDamage";
            this.labelAttackAddDamage.Size = new System.Drawing.Size(36, 13);
            this.labelAttackAddDamage.TabIndex = 1;
            this.labelAttackAddDamage.Text = "Dano:";
            // 
            // labelAttackAddName
            // 
            this.labelAttackAddName.AutoSize = true;
            this.labelAttackAddName.Location = new System.Drawing.Point(16, 29);
            this.labelAttackAddName.Name = "labelAttackAddName";
            this.labelAttackAddName.Size = new System.Drawing.Size(38, 13);
            this.labelAttackAddName.TabIndex = 0;
            this.labelAttackAddName.Text = "Nome:";
            // 
            // modifyAttack
            // 
            this.modifyAttack.Controls.Add(this.dataGridView1);
            this.modifyAttack.Controls.Add(this.inputAttackModifyType);
            this.modifyAttack.Controls.Add(this.inputAttackModifyPrecision);
            this.modifyAttack.Controls.Add(this.inputAttackModifyPP);
            this.modifyAttack.Controls.Add(this.inputAttackModifyDamage);
            this.modifyAttack.Controls.Add(this.inputAttackModifyName);
            this.modifyAttack.Controls.Add(this.labelAttackModifyType);
            this.modifyAttack.Controls.Add(this.labelAttackModifyPrecision);
            this.modifyAttack.Controls.Add(this.labelAttackModifyPP);
            this.modifyAttack.Controls.Add(this.labelAttackModifyDamage);
            this.modifyAttack.Controls.Add(this.labelAttackModifyName);
            this.modifyAttack.Location = new System.Drawing.Point(4, 22);
            this.modifyAttack.Name = "modifyAttack";
            this.modifyAttack.Size = new System.Drawing.Size(742, 474);
            this.modifyAttack.TabIndex = 2;
            this.modifyAttack.Text = "Modificar Ataque";
            this.modifyAttack.UseVisualStyleBackColor = true;
            // 
            // attackTypeCustomBindingSource
            // 
            this.attackTypeCustomBindingSource.DataMember = "AttackTypeCustom";
            this.attackTypeCustomBindingSource.DataSource = this.pokeHandDataSet;
            // 
            // deleteAttack
            // 
            this.deleteAttack.Location = new System.Drawing.Point(4, 22);
            this.deleteAttack.Name = "deleteAttack";
            this.deleteAttack.Size = new System.Drawing.Size(742, 474);
            this.deleteAttack.TabIndex = 3;
            this.deleteAttack.Text = "Excluir Ataque";
            this.deleteAttack.UseVisualStyleBackColor = true;
            // 
            // attackBindingSource2
            // 
            this.attackBindingSource2.DataMember = "attack";
            this.attackBindingSource2.DataSource = this.pokeHandDataSet;
            // 
            // attackBindingSource
            // 
            this.attackBindingSource.DataMember = "attack";
            this.attackBindingSource.DataSource = this.pokeHandDataSet;
            // 
            // attackTableAdapter
            // 
            this.attackTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // attackBindingSource1
            // 
            this.attackBindingSource1.DataMember = "attack";
            this.attackBindingSource1.DataSource = this.pokeHandDataSet;
            // 
            // attackBindingSource3
            // 
            this.attackBindingSource3.DataMember = "attack";
            this.attackBindingSource3.DataSource = this.pokeHandDataSet;
            // 
            // attackTypeCustomAdapter
            // 
            this.attackTypeCustomAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.damageDataGridViewTextBoxColumn,
            this.powerpointDataGridViewTextBoxColumn,
            this.accuracyDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attackTypeCustomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // damageDataGridViewTextBoxColumn
            // 
            this.damageDataGridViewTextBoxColumn.DataPropertyName = "damage";
            this.damageDataGridViewTextBoxColumn.HeaderText = "damage";
            this.damageDataGridViewTextBoxColumn.Name = "damageDataGridViewTextBoxColumn";
            // 
            // powerpointDataGridViewTextBoxColumn
            // 
            this.powerpointDataGridViewTextBoxColumn.DataPropertyName = "power_point";
            this.powerpointDataGridViewTextBoxColumn.HeaderText = "power_point";
            this.powerpointDataGridViewTextBoxColumn.Name = "powerpointDataGridViewTextBoxColumn";
            // 
            // accuracyDataGridViewTextBoxColumn
            // 
            this.accuracyDataGridViewTextBoxColumn.DataPropertyName = "accuracy";
            this.accuracyDataGridViewTextBoxColumn.HeaderText = "accuracy";
            this.accuracyDataGridViewTextBoxColumn.Name = "accuracyDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // inputAttackModifyType
            // 
            this.inputAttackModifyType.DataSource = this.typeBindingSource;
            this.inputAttackModifyType.DisplayMember = "name";
            this.inputAttackModifyType.FormattingEnabled = true;
            this.inputAttackModifyType.Location = new System.Drawing.Point(458, 124);
            this.inputAttackModifyType.Name = "inputAttackModifyType";
            this.inputAttackModifyType.Size = new System.Drawing.Size(120, 95);
            this.inputAttackModifyType.TabIndex = 30;
            this.inputAttackModifyType.ValueMember = "id";
            // 
            // inputAttackModifyPrecision
            // 
            this.inputAttackModifyPrecision.Location = new System.Drawing.Point(256, 124);
            this.inputAttackModifyPrecision.Name = "inputAttackModifyPrecision";
            this.inputAttackModifyPrecision.Size = new System.Drawing.Size(100, 20);
            this.inputAttackModifyPrecision.TabIndex = 29;
            // 
            // inputAttackModifyPP
            // 
            this.inputAttackModifyPP.Location = new System.Drawing.Point(78, 124);
            this.inputAttackModifyPP.Name = "inputAttackModifyPP";
            this.inputAttackModifyPP.Size = new System.Drawing.Size(100, 20);
            this.inputAttackModifyPP.TabIndex = 28;
            // 
            // inputAttackModifyDamage
            // 
            this.inputAttackModifyDamage.Location = new System.Drawing.Point(447, 67);
            this.inputAttackModifyDamage.Name = "inputAttackModifyDamage";
            this.inputAttackModifyDamage.Size = new System.Drawing.Size(241, 20);
            this.inputAttackModifyDamage.TabIndex = 27;
            // 
            // inputAttackModifyName
            // 
            this.inputAttackModifyName.Location = new System.Drawing.Point(92, 67);
            this.inputAttackModifyName.Name = "inputAttackModifyName";
            this.inputAttackModifyName.Size = new System.Drawing.Size(264, 20);
            this.inputAttackModifyName.TabIndex = 26;
            // 
            // labelAttackModifyType
            // 
            this.labelAttackModifyType.AutoSize = true;
            this.labelAttackModifyType.Location = new System.Drawing.Point(405, 127);
            this.labelAttackModifyType.Name = "labelAttackModifyType";
            this.labelAttackModifyType.Size = new System.Drawing.Size(31, 13);
            this.labelAttackModifyType.TabIndex = 25;
            this.labelAttackModifyType.Text = "Tipo:";
            // 
            // labelAttackModifyPrecision
            // 
            this.labelAttackModifyPrecision.AutoSize = true;
            this.labelAttackModifyPrecision.Location = new System.Drawing.Point(199, 127);
            this.labelAttackModifyPrecision.Name = "labelAttackModifyPrecision";
            this.labelAttackModifyPrecision.Size = new System.Drawing.Size(51, 13);
            this.labelAttackModifyPrecision.TabIndex = 24;
            this.labelAttackModifyPrecision.Text = "Precisão:";
            // 
            // labelAttackModifyPP
            // 
            this.labelAttackModifyPP.AutoSize = true;
            this.labelAttackModifyPP.Location = new System.Drawing.Point(48, 127);
            this.labelAttackModifyPP.Name = "labelAttackModifyPP";
            this.labelAttackModifyPP.Size = new System.Drawing.Size(24, 13);
            this.labelAttackModifyPP.TabIndex = 23;
            this.labelAttackModifyPP.Text = "PP:";
            // 
            // labelAttackModifyDamage
            // 
            this.labelAttackModifyDamage.AutoSize = true;
            this.labelAttackModifyDamage.Location = new System.Drawing.Point(405, 74);
            this.labelAttackModifyDamage.Name = "labelAttackModifyDamage";
            this.labelAttackModifyDamage.Size = new System.Drawing.Size(36, 13);
            this.labelAttackModifyDamage.TabIndex = 22;
            this.labelAttackModifyDamage.Text = "Dano:";
            // 
            // labelAttackModifyName
            // 
            this.labelAttackModifyName.AutoSize = true;
            this.labelAttackModifyName.Location = new System.Drawing.Point(48, 74);
            this.labelAttackModifyName.Name = "labelAttackModifyName";
            this.labelAttackModifyName.Size = new System.Drawing.Size(38, 13);
            this.labelAttackModifyName.TabIndex = 21;
            this.labelAttackModifyName.Text = "Nome:";
            // 
            // Attacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.attacksControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attacks";
            this.Text = "Ataques";
            this.Load += new System.EventHandler(this.Attacks_Load);
            this.attacksControl.ResumeLayout(false);
            this.addAttack.ResumeLayout(false);
            this.addAttack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).EndInit();
            this.modifyAttack.ResumeLayout(false);
            this.modifyAttack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackTypeCustomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl attacksControl;
        private System.Windows.Forms.TabPage searchAttack;
        private System.Windows.Forms.TabPage addAttack;
        private System.Windows.Forms.TabPage modifyAttack;
        private System.Windows.Forms.TabPage deleteAttack;
        private PokeHandDataSet pokeHandDataSet;
        private System.Windows.Forms.BindingSource attackBindingSource;
        private PokeHandDataSetTableAdapters.attackTableAdapter attackTableAdapter;
        private System.Windows.Forms.Label labelAttackAddName;
        private System.Windows.Forms.Label labelAttackAddPrecision;
        private System.Windows.Forms.Label labelAttackAddPP;
        private System.Windows.Forms.Label labelAttackAddDamage;
        private System.Windows.Forms.ListBox listBoxAttackAddType;
        private System.Windows.Forms.TextBox inputAttackAddPrecision;
        private System.Windows.Forms.TextBox inputAttackAddPP;
        private System.Windows.Forms.TextBox inputAttackAddDamage;
        private System.Windows.Forms.TextBox inputAttackAddName;
        private System.Windows.Forms.Label labelAttackAddType;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private PokeHandDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Button buttonAttackAddSave;
        private System.Windows.Forms.BindingSource attackBindingSource1;
        private System.Windows.Forms.BindingSource attackBindingSource2;
        private System.Windows.Forms.BindingSource attackBindingSource3;
        private System.Windows.Forms.BindingSource attackTypeCustomBindingSource;
        private PokeHandDataSetTableAdapters.AttackTypeCustomAdapter attackTypeCustomAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox inputAttackModifyType;
        private System.Windows.Forms.TextBox inputAttackModifyPrecision;
        private System.Windows.Forms.TextBox inputAttackModifyPP;
        private System.Windows.Forms.TextBox inputAttackModifyDamage;
        private System.Windows.Forms.TextBox inputAttackModifyName;
        private System.Windows.Forms.Label labelAttackModifyType;
        private System.Windows.Forms.Label labelAttackModifyPrecision;
        private System.Windows.Forms.Label labelAttackModifyPP;
        private System.Windows.Forms.Label labelAttackModifyDamage;
        private System.Windows.Forms.Label labelAttackModifyName;
    }
}
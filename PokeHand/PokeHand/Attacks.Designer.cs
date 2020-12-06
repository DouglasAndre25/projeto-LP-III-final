﻿namespace PokeHand
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
            this.labelAttackAddType = new System.Windows.Forms.Label();
            this.inputAttackAddType = new System.Windows.Forms.ListBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokeHandDataSet = new PokeHand.PokeHandDataSet();
            this.labelAttackAddAccuracy = new System.Windows.Forms.Label();
            this.inputAttackAddAccuracy = new System.Windows.Forms.TextBox();
            this.labelAttackAddPowerPoint = new System.Windows.Forms.Label();
            this.inputAttackAddPowerPoint = new System.Windows.Forms.TextBox();
            this.labelAttackAddDamage = new System.Windows.Forms.Label();
            this.inputAttackAddDamage = new System.Windows.Forms.TextBox();
            this.labelAttackAddName = new System.Windows.Forms.Label();
            this.inputAttackAddName = new System.Windows.Forms.TextBox();
            this.modifyAttack = new System.Windows.Forms.TabPage();
            this.deleteAttack = new System.Windows.Forms.TabPage();
            this.typeTableAdapter = new PokeHand.PokeHandDataSetTableAdapters.typeTableAdapter();
            this.addAttackButton = new System.Windows.Forms.Button();
            this.attacksControl.SuspendLayout();
            this.addAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeHandDataSet)).BeginInit();
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
            this.addAttack.Controls.Add(this.addAttackButton);
            this.addAttack.Controls.Add(this.labelAttackAddType);
            this.addAttack.Controls.Add(this.inputAttackAddType);
            this.addAttack.Controls.Add(this.labelAttackAddAccuracy);
            this.addAttack.Controls.Add(this.inputAttackAddAccuracy);
            this.addAttack.Controls.Add(this.labelAttackAddPowerPoint);
            this.addAttack.Controls.Add(this.inputAttackAddPowerPoint);
            this.addAttack.Controls.Add(this.labelAttackAddDamage);
            this.addAttack.Controls.Add(this.inputAttackAddDamage);
            this.addAttack.Controls.Add(this.labelAttackAddName);
            this.addAttack.Controls.Add(this.inputAttackAddName);
            this.addAttack.Location = new System.Drawing.Point(4, 22);
            this.addAttack.Name = "addAttack";
            this.addAttack.Padding = new System.Windows.Forms.Padding(3);
            this.addAttack.Size = new System.Drawing.Size(742, 474);
            this.addAttack.TabIndex = 1;
            this.addAttack.Text = "Adicionar Ataque";
            this.addAttack.UseVisualStyleBackColor = true;
            // 
            // labelAttackAddType
            // 
            this.labelAttackAddType.AutoSize = true;
            this.labelAttackAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackAddType.Location = new System.Drawing.Point(378, 23);
            this.labelAttackAddType.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelAttackAddType.Name = "labelAttackAddType";
            this.labelAttackAddType.Size = new System.Drawing.Size(39, 16);
            this.labelAttackAddType.TabIndex = 13;
            this.labelAttackAddType.Text = "Tipo:";
            // 
            // inputAttackAddType
            // 
            this.inputAttackAddType.DataSource = this.typeBindingSource;
            this.inputAttackAddType.DisplayMember = "name";
            this.inputAttackAddType.FormattingEnabled = true;
            this.inputAttackAddType.Location = new System.Drawing.Point(381, 43);
            this.inputAttackAddType.Name = "inputAttackAddType";
            this.inputAttackAddType.Size = new System.Drawing.Size(341, 82);
            this.inputAttackAddType.TabIndex = 12;
            this.inputAttackAddType.ValueMember = "id";
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
            // labelAttackAddAccuracy
            // 
            this.labelAttackAddAccuracy.AutoSize = true;
            this.labelAttackAddAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackAddAccuracy.Location = new System.Drawing.Point(378, 135);
            this.labelAttackAddAccuracy.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelAttackAddAccuracy.Name = "labelAttackAddAccuracy";
            this.labelAttackAddAccuracy.Size = new System.Drawing.Size(65, 16);
            this.labelAttackAddAccuracy.TabIndex = 11;
            this.labelAttackAddAccuracy.Text = "Precisão:";
            // 
            // inputAttackAddAccuracy
            // 
            this.inputAttackAddAccuracy.Location = new System.Drawing.Point(378, 155);
            this.inputAttackAddAccuracy.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputAttackAddAccuracy.Name = "inputAttackAddAccuracy";
            this.inputAttackAddAccuracy.Size = new System.Drawing.Size(344, 20);
            this.inputAttackAddAccuracy.TabIndex = 10;
            // 
            // labelAttackAddPowerPoint
            // 
            this.labelAttackAddPowerPoint.AutoSize = true;
            this.labelAttackAddPowerPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackAddPowerPoint.Location = new System.Drawing.Point(23, 135);
            this.labelAttackAddPowerPoint.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelAttackAddPowerPoint.Name = "labelAttackAddPowerPoint";
            this.labelAttackAddPowerPoint.Size = new System.Drawing.Size(29, 16);
            this.labelAttackAddPowerPoint.TabIndex = 9;
            this.labelAttackAddPowerPoint.Text = "PP:";
            // 
            // inputAttackAddPowerPoint
            // 
            this.inputAttackAddPowerPoint.Location = new System.Drawing.Point(23, 155);
            this.inputAttackAddPowerPoint.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputAttackAddPowerPoint.Name = "inputAttackAddPowerPoint";
            this.inputAttackAddPowerPoint.Size = new System.Drawing.Size(344, 20);
            this.inputAttackAddPowerPoint.TabIndex = 8;
            // 
            // labelAttackAddDamage
            // 
            this.labelAttackAddDamage.AutoSize = true;
            this.labelAttackAddDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackAddDamage.Location = new System.Drawing.Point(23, 78);
            this.labelAttackAddDamage.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelAttackAddDamage.Name = "labelAttackAddDamage";
            this.labelAttackAddDamage.Size = new System.Drawing.Size(44, 16);
            this.labelAttackAddDamage.TabIndex = 7;
            this.labelAttackAddDamage.Text = "Dano:";
            // 
            // inputAttackAddDamage
            // 
            this.inputAttackAddDamage.Location = new System.Drawing.Point(23, 98);
            this.inputAttackAddDamage.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputAttackAddDamage.Name = "inputAttackAddDamage";
            this.inputAttackAddDamage.Size = new System.Drawing.Size(344, 20);
            this.inputAttackAddDamage.TabIndex = 6;
            // 
            // labelAttackAddName
            // 
            this.labelAttackAddName.AutoSize = true;
            this.labelAttackAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackAddName.Location = new System.Drawing.Point(23, 23);
            this.labelAttackAddName.Margin = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.labelAttackAddName.Name = "labelAttackAddName";
            this.labelAttackAddName.Size = new System.Drawing.Size(48, 16);
            this.labelAttackAddName.TabIndex = 5;
            this.labelAttackAddName.Text = "Nome:";
            // 
            // inputAttackAddName
            // 
            this.inputAttackAddName.Location = new System.Drawing.Point(23, 43);
            this.inputAttackAddName.Margin = new System.Windows.Forms.Padding(20, 2, 20, 20);
            this.inputAttackAddName.Name = "inputAttackAddName";
            this.inputAttackAddName.Size = new System.Drawing.Size(344, 20);
            this.inputAttackAddName.TabIndex = 4;
            // 
            // modifyAttack
            // 
            this.modifyAttack.Location = new System.Drawing.Point(4, 22);
            this.modifyAttack.Name = "modifyAttack";
            this.modifyAttack.Size = new System.Drawing.Size(742, 474);
            this.modifyAttack.TabIndex = 2;
            this.modifyAttack.Text = "Modificar Ataque";
            this.modifyAttack.UseVisualStyleBackColor = true;
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
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // addAttackButton
            // 
            this.addAttackButton.Location = new System.Drawing.Point(23, 204);
            this.addAttackButton.Margin = new System.Windows.Forms.Padding(20);
            this.addAttackButton.Name = "addAttackButton";
            this.addAttackButton.Size = new System.Drawing.Size(75, 23);
            this.addAttackButton.TabIndex = 14;
            this.addAttackButton.Text = "Adicionar";
            this.addAttackButton.UseVisualStyleBackColor = true;
            this.addAttackButton.Click += new System.EventHandler(this.addAttackButton_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl attacksControl;
        private System.Windows.Forms.TabPage searchAttack;
        private System.Windows.Forms.TabPage addAttack;
        private System.Windows.Forms.TabPage modifyAttack;
        private System.Windows.Forms.TabPage deleteAttack;
        private System.Windows.Forms.Label labelAttackAddAccuracy;
        private System.Windows.Forms.TextBox inputAttackAddAccuracy;
        private System.Windows.Forms.Label labelAttackAddPowerPoint;
        private System.Windows.Forms.TextBox inputAttackAddPowerPoint;
        private System.Windows.Forms.Label labelAttackAddDamage;
        private System.Windows.Forms.TextBox inputAttackAddDamage;
        private System.Windows.Forms.Label labelAttackAddName;
        private System.Windows.Forms.TextBox inputAttackAddName;
        private System.Windows.Forms.ListBox inputAttackAddType;
        private PokeHandDataSet pokeHandDataSet;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private PokeHandDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Label labelAttackAddType;
        private System.Windows.Forms.Button addAttackButton;
    }
}
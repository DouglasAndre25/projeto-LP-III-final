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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attacks));
            this.attacksControl = new System.Windows.Forms.TabControl();
            this.searchAttack = new System.Windows.Forms.TabPage();
            this.addAttack = new System.Windows.Forms.TabPage();
            this.modifyAttack = new System.Windows.Forms.TabPage();
            this.deleteAttack = new System.Windows.Forms.TabPage();
            this.attacksControl.SuspendLayout();
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
            this.addAttack.Location = new System.Drawing.Point(4, 22);
            this.addAttack.Name = "addAttack";
            this.addAttack.Padding = new System.Windows.Forms.Padding(3);
            this.addAttack.Size = new System.Drawing.Size(742, 474);
            this.addAttack.TabIndex = 1;
            this.addAttack.Text = "Adicionar Ataque";
            this.addAttack.UseVisualStyleBackColor = true;
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
            // Attacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.attacksControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attacks";
            this.Text = "Ataques";
            this.attacksControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl attacksControl;
        private System.Windows.Forms.TabPage searchAttack;
        private System.Windows.Forms.TabPage addAttack;
        private System.Windows.Forms.TabPage modifyAttack;
        private System.Windows.Forms.TabPage deleteAttack;
    }
}
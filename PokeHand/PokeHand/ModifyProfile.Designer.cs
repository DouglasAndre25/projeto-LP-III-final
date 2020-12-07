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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProfile));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.profileData = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputProfileName = new System.Windows.Forms.TextBox();
            this.labelTypeAddName = new System.Windows.Forms.Label();
            this.inputProfileAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputProfileVocation = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.profileSubmitButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.profileData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.profileData);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(19, 19);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(750, 523);
            this.tabControl.TabIndex = 0;
            // 
            // profileData
            // 
            this.profileData.Controls.Add(this.groupBox1);
            this.profileData.Location = new System.Drawing.Point(4, 22);
            this.profileData.Name = "profileData";
            this.profileData.Padding = new System.Windows.Forms.Padding(3);
            this.profileData.Size = new System.Drawing.Size(742, 497);
            this.profileData.TabIndex = 0;
            this.profileData.Text = "Dados";
            this.profileData.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipe";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox1.Size = new System.Drawing.Size(696, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meus Dados";
            // 
            // inputProfileName
            // 
            this.inputProfileName.Location = new System.Drawing.Point(13, 46);
            this.inputProfileName.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.inputProfileName.Name = "inputProfileName";
            this.inputProfileName.Size = new System.Drawing.Size(325, 20);
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
            // inputProfileAge
            // 
            this.inputProfileAge.Location = new System.Drawing.Point(13, 106);
            this.inputProfileAge.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.inputProfileAge.Name = "inputProfileAge";
            this.inputProfileAge.Size = new System.Drawing.Size(325, 20);
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
            this.inputProfileVocation.Location = new System.Drawing.Point(378, 46);
            this.inputProfileVocation.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.inputProfileVocation.Name = "inputProfileVocation";
            this.inputProfileVocation.Size = new System.Drawing.Size(305, 82);
            this.inputProfileVocation.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profissão:";
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
            // ModifyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyProfile";
            this.Text = "Modificar Perfil";
            this.tabControl.ResumeLayout(false);
            this.profileData.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
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
    }
}
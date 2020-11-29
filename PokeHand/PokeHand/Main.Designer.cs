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
            this.mainSection.SuspendLayout();
            this.dataSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.Font = new System.Drawing.Font("Pokemon Solid", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.logoText.Location = new System.Drawing.Point(257, 199);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(271, 101);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "PokeHand v1.0";
            // 
            // mainSection
            // 
            this.mainSection.Controls.Add(this.modifyProfileButton);
            this.mainSection.Controls.Add(this.viewProfileButton);
            this.mainSection.Location = new System.Drawing.Point(214, 310);
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
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Location = new System.Drawing.Point(19, 40);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(136, 29);
            this.viewProfileButton.TabIndex = 0;
            this.viewProfileButton.Text = "Meu Perfil";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            // 
            // attacksButton
            // 
            this.attacksButton.Location = new System.Drawing.Point(19, 60);
            this.attacksButton.Name = "attacksButton";
            this.attacksButton.Size = new System.Drawing.Size(136, 29);
            this.attacksButton.TabIndex = 1;
            this.attacksButton.Text = "Ataques";
            this.attacksButton.UseVisualStyleBackColor = true;
            // 
            // pokemonsButton
            // 
            this.pokemonsButton.Location = new System.Drawing.Point(19, 25);
            this.pokemonsButton.Name = "pokemonsButton";
            this.pokemonsButton.Size = new System.Drawing.Size(136, 29);
            this.pokemonsButton.TabIndex = 0;
            this.pokemonsButton.Text = "Pokémons";
            this.pokemonsButton.UseVisualStyleBackColor = true;
            // 
            // dataSection
            // 
            this.dataSection.Controls.Add(this.typesButton);
            this.dataSection.Controls.Add(this.attacksButton);
            this.dataSection.Controls.Add(this.pokemonsButton);
            this.dataSection.Location = new System.Drawing.Point(395, 310);
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
            this.pictureBox1.Location = new System.Drawing.Point(328, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataSection);
            this.Controls.Add(this.mainSection);
            this.Controls.Add(this.logoText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "PokeHand";
            this.mainSection.ResumeLayout(false);
            this.dataSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}


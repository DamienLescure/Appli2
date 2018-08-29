namespace Appli2
{
    partial class FrmAppli2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnRetablir = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.GpBoxParam = new System.Windows.Forms.GroupBox();
            this.TxtBoxTemp = new System.Windows.Forms.TextBox();
            this.TxtBoxVit = new System.Windows.Forms.TextBox();
            this.LblTemp = new System.Windows.Forms.Label();
            this.LblVit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxVit = new System.Windows.Forms.ComboBox();
            this.CBoxTemp = new System.Windows.Forms.ComboBox();
            this.GpBoxParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(386, 24);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 28);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnRetablir
            // 
            this.BtnRetablir.Location = new System.Drawing.Point(386, 54);
            this.BtnRetablir.Name = "BtnRetablir";
            this.BtnRetablir.Size = new System.Drawing.Size(75, 28);
            this.BtnRetablir.TabIndex = 3;
            this.BtnRetablir.Text = "Rétablir";
            this.BtnRetablir.UseVisualStyleBackColor = true;
            this.BtnRetablir.Click += new System.EventHandler(this.BtnRetablir_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(386, 84);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 28);
            this.BtnQuitter.TabIndex = 4;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // GpBoxParam
            // 
            this.GpBoxParam.Controls.Add(this.TxtBoxTemp);
            this.GpBoxParam.Controls.Add(this.TxtBoxVit);
            this.GpBoxParam.Controls.Add(this.LblTemp);
            this.GpBoxParam.Controls.Add(this.LblVit);
            this.GpBoxParam.Enabled = false;
            this.GpBoxParam.Location = new System.Drawing.Point(16, 159);
            this.GpBoxParam.Name = "GpBoxParam";
            this.GpBoxParam.Size = new System.Drawing.Size(255, 100);
            this.GpBoxParam.TabIndex = 5;
            this.GpBoxParam.TabStop = false;
            this.GpBoxParam.Text = "Paramètres retenus";
            this.GpBoxParam.Visible = false;
            // 
            // TxtBoxTemp
            // 
            this.TxtBoxTemp.Location = new System.Drawing.Point(100, 60);
            this.TxtBoxTemp.Name = "TxtBoxTemp";
            this.TxtBoxTemp.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxTemp.TabIndex = 3;
            // 
            // TxtBoxVit
            // 
            this.TxtBoxVit.Location = new System.Drawing.Point(100, 22);
            this.TxtBoxVit.Name = "TxtBoxVit";
            this.TxtBoxVit.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxVit.TabIndex = 2;
            // 
            // LblTemp
            // 
            this.LblTemp.AutoSize = true;
            this.LblTemp.Location = new System.Drawing.Point(6, 63);
            this.LblTemp.Name = "LblTemp";
            this.LblTemp.Size = new System.Drawing.Size(73, 13);
            this.LblTemp.TabIndex = 1;
            this.LblTemp.Text = "Température :";
            // 
            // LblVit
            // 
            this.LblVit.AutoSize = true;
            this.LblVit.Location = new System.Drawing.Point(7, 30);
            this.LblVit.Name = "LblVit";
            this.LblVit.Size = new System.Drawing.Size(47, 13);
            this.LblVit.TabIndex = 0;
            this.LblVit.Text = "Vitesse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choisir une vitesse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choisir une température :";
            // 
            // CBoxVit
            // 
            this.CBoxVit.DisplayMember = "100";
            this.CBoxVit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxVit.FormattingEnabled = true;
            this.CBoxVit.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500"});
            this.CBoxVit.Location = new System.Drawing.Point(147, 24);
            this.CBoxVit.Name = "CBoxVit";
            this.CBoxVit.Size = new System.Drawing.Size(121, 21);
            this.CBoxVit.Sorted = true;
            this.CBoxVit.TabIndex = 8;
            this.CBoxVit.SelectedIndexChanged += new System.EventHandler(this.CBoxVit_SelectedIndexChanged);
            // 
            // CBoxTemp
            // 
            this.CBoxTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTemp.FormattingEnabled = true;
            this.CBoxTemp.Items.AddRange(new object[] {
            "50",
            "80",
            "100"});
            this.CBoxTemp.Location = new System.Drawing.Point(147, 68);
            this.CBoxTemp.Name = "CBoxTemp";
            this.CBoxTemp.Size = new System.Drawing.Size(121, 21);
            this.CBoxTemp.TabIndex = 9;
            // 
            // FrmAppli2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 279);
            this.Controls.Add(this.CBoxTemp);
            this.Controls.Add(this.CBoxVit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GpBoxParam);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnRetablir);
            this.Controls.Add(this.BtnOK);
            this.Name = "FrmAppli2";
            this.Text = "Paramètres de l\'analyseur";
            this.Load += new System.EventHandler(this.FrmAppli2_Load);
            this.GpBoxParam.ResumeLayout(false);
            this.GpBoxParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnRetablir;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.GroupBox GpBoxParam;
        private System.Windows.Forms.TextBox TxtBoxTemp;
        private System.Windows.Forms.TextBox TxtBoxVit;
        private System.Windows.Forms.Label LblTemp;
        private System.Windows.Forms.Label LblVit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxVit;
        private System.Windows.Forms.ComboBox CBoxTemp;
    }
}


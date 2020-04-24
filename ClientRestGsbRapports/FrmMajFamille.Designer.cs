namespace ClientRestGsbRapports
{
    partial class FrmMajFamille
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
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.btnMaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFamille
            // 
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(80, 35);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(192, 21);
            this.cmbFamille.TabIndex = 0;
            this.cmbFamille.SelectedIndexChanged += new System.EventHandler(this.cmbFamille_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les familles";
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(16, 155);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(203, 20);
            this.txtFamille.TabIndex = 2;
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(90, 207);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(75, 23);
            this.btnMaj.TabIndex = 3;
            this.btnMaj.Text = "Mettre à jour";
            this.btnMaj.UseVisualStyleBackColor = true;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click);
            // 
            // FrmMajFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMaj);
            this.Controls.Add(this.txtFamille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFamille);
            this.Name = "FrmMajFamille";
            this.Text = "Mise à jour d\'une famille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamille;
        private System.Windows.Forms.Button btnMaj;
    }
}
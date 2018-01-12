namespace Escritorio
{
    partial class ABMExpulsados
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
            this.btnExpulsados = new System.Windows.Forms.Button();
            this.lblExpulsado1 = new System.Windows.Forms.Label();
            this.lblExpulsado2 = new System.Windows.Forms.Label();
            this.lblExpulsado3 = new System.Windows.Forms.Label();
            this.lblExpulsado4 = new System.Windows.Forms.Label();
            this.cmbExpulsado1 = new System.Windows.Forms.ComboBox();
            this.cmbExpulsado2 = new System.Windows.Forms.ComboBox();
            this.cmbExpulsado3 = new System.Windows.Forms.ComboBox();
            this.cmbExpulsado4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExpulsados
            // 
            this.btnExpulsados.Location = new System.Drawing.Point(91, 177);
            this.btnExpulsados.Name = "btnExpulsados";
            this.btnExpulsados.Size = new System.Drawing.Size(176, 36);
            this.btnExpulsados.TabIndex = 0;
            this.btnExpulsados.UseVisualStyleBackColor = true;
            this.btnExpulsados.Click += new System.EventHandler(this.btnExpulsados_Click);
            // 
            // lblExpulsado1
            // 
            this.lblExpulsado1.AutoSize = true;
            this.lblExpulsado1.Location = new System.Drawing.Point(75, 44);
            this.lblExpulsado1.Name = "lblExpulsado1";
            this.lblExpulsado1.Size = new System.Drawing.Size(65, 13);
            this.lblExpulsado1.TabIndex = 1;
            this.lblExpulsado1.Text = "Expulsado 1";
            // 
            // lblExpulsado2
            // 
            this.lblExpulsado2.AutoSize = true;
            this.lblExpulsado2.Location = new System.Drawing.Point(75, 71);
            this.lblExpulsado2.Name = "lblExpulsado2";
            this.lblExpulsado2.Size = new System.Drawing.Size(65, 13);
            this.lblExpulsado2.TabIndex = 2;
            this.lblExpulsado2.Text = "Expulsado 2";
            // 
            // lblExpulsado3
            // 
            this.lblExpulsado3.AutoSize = true;
            this.lblExpulsado3.Location = new System.Drawing.Point(75, 98);
            this.lblExpulsado3.Name = "lblExpulsado3";
            this.lblExpulsado3.Size = new System.Drawing.Size(65, 13);
            this.lblExpulsado3.TabIndex = 3;
            this.lblExpulsado3.Text = "Expulsado 3";
            // 
            // lblExpulsado4
            // 
            this.lblExpulsado4.AutoSize = true;
            this.lblExpulsado4.Location = new System.Drawing.Point(75, 125);
            this.lblExpulsado4.Name = "lblExpulsado4";
            this.lblExpulsado4.Size = new System.Drawing.Size(65, 13);
            this.lblExpulsado4.TabIndex = 4;
            this.lblExpulsado4.Text = "Expulsado 4";
            // 
            // cmbExpulsado1
            // 
            this.cmbExpulsado1.FormattingEnabled = true;
            this.cmbExpulsado1.Location = new System.Drawing.Point(146, 41);
            this.cmbExpulsado1.Name = "cmbExpulsado1";
            this.cmbExpulsado1.Size = new System.Drawing.Size(121, 21);
            this.cmbExpulsado1.TabIndex = 5;
            // 
            // cmbExpulsado2
            // 
            this.cmbExpulsado2.FormattingEnabled = true;
            this.cmbExpulsado2.Location = new System.Drawing.Point(146, 68);
            this.cmbExpulsado2.Name = "cmbExpulsado2";
            this.cmbExpulsado2.Size = new System.Drawing.Size(121, 21);
            this.cmbExpulsado2.TabIndex = 5;
            // 
            // cmbExpulsado3
            // 
            this.cmbExpulsado3.FormattingEnabled = true;
            this.cmbExpulsado3.Location = new System.Drawing.Point(146, 95);
            this.cmbExpulsado3.Name = "cmbExpulsado3";
            this.cmbExpulsado3.Size = new System.Drawing.Size(121, 21);
            this.cmbExpulsado3.TabIndex = 5;
            // 
            // cmbExpulsado4
            // 
            this.cmbExpulsado4.FormattingEnabled = true;
            this.cmbExpulsado4.Location = new System.Drawing.Point(146, 122);
            this.cmbExpulsado4.Name = "cmbExpulsado4";
            this.cmbExpulsado4.Size = new System.Drawing.Size(121, 21);
            this.cmbExpulsado4.TabIndex = 5;
            // 
            // ABMExpulsados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 248);
            this.Controls.Add(this.cmbExpulsado4);
            this.Controls.Add(this.cmbExpulsado3);
            this.Controls.Add(this.cmbExpulsado2);
            this.Controls.Add(this.cmbExpulsado1);
            this.Controls.Add(this.lblExpulsado4);
            this.Controls.Add(this.lblExpulsado3);
            this.Controls.Add(this.lblExpulsado2);
            this.Controls.Add(this.lblExpulsado1);
            this.Controls.Add(this.btnExpulsados);
            this.Name = "ABMExpulsados";
            this.Text = "ABMExpulsados";
            this.Load += new System.EventHandler(this.ABMExpulsados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpulsados;
        private System.Windows.Forms.Label lblExpulsado1;
        private System.Windows.Forms.Label lblExpulsado2;
        private System.Windows.Forms.Label lblExpulsado3;
        private System.Windows.Forms.Label lblExpulsado4;
        private System.Windows.Forms.ComboBox cmbExpulsado1;
        private System.Windows.Forms.ComboBox cmbExpulsado2;
        private System.Windows.Forms.ComboBox cmbExpulsado3;
        private System.Windows.Forms.ComboBox cmbExpulsado4;
    }
}
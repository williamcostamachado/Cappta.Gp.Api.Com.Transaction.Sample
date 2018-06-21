namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    partial class Configuracao
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
            this.Salvar = new System.Windows.Forms.Button();
            this.textBoxChave = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxPdv = new System.Windows.Forms.TextBox();
            this.labelPdv = new System.Windows.Forms.Label();
            this.textBoxCnpj = new System.Windows.Forms.TextBox();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(359, 88);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(123, 23);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar Configuração";
            this.Salvar.UseVisualStyleBackColor = true;
            // 
            // textBoxChave
            // 
            this.textBoxChave.Location = new System.Drawing.Point(134, 12);
            this.textBoxChave.Name = "textBoxChave";
            this.textBoxChave.Size = new System.Drawing.Size(353, 20);
            this.textBoxChave.TabIndex = 1;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 15);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(119, 13);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Chave de Autenticação";
            // 
            // textBoxPdv
            // 
            this.textBoxPdv.Location = new System.Drawing.Point(46, 38);
            this.textBoxPdv.Name = "textBoxPdv";
            this.textBoxPdv.Size = new System.Drawing.Size(59, 20);
            this.textBoxPdv.TabIndex = 3;
            // 
            // labelPdv
            // 
            this.labelPdv.AutoSize = true;
            this.labelPdv.Location = new System.Drawing.Point(12, 41);
            this.labelPdv.Name = "labelPdv";
            this.labelPdv.Size = new System.Drawing.Size(29, 13);
            this.labelPdv.TabIndex = 4;
            this.labelPdv.Text = "PDV";
            // 
            // textBoxCnpj
            // 
            this.textBoxCnpj.Location = new System.Drawing.Point(281, 38);
            this.textBoxCnpj.Name = "textBoxCnpj";
            this.textBoxCnpj.Size = new System.Drawing.Size(206, 20);
            this.textBoxCnpj.TabIndex = 5;
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(230, 41);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 13);
            this.labelCnpj.TabIndex = 6;
            this.labelCnpj.Text = "CNPJ";
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 114);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.textBoxCnpj);
            this.Controls.Add(this.labelPdv);
            this.Controls.Add(this.textBoxPdv);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxChave);
            this.Controls.Add(this.Salvar);
            this.Name = "Configuracao";
            this.Text = "Configuracao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox textBoxChave;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxPdv;
        private System.Windows.Forms.Label labelPdv;
        private System.Windows.Forms.TextBox textBoxCnpj;
        private System.Windows.Forms.Label labelCnpj;
    }
}
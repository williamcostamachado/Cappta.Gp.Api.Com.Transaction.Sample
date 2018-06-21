namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    partial class Pagamento
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
            this.valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDebito = new System.Windows.Forms.RadioButton();
            this.radioButtonCredito = new System.Windows.Forms.RadioButton();
            this.radioButtonCrediario = new System.Windows.Forms.RadioButton();
            this.pagamentoDebito = new System.Windows.Forms.Button();
            this.pagamentoCredito = new System.Windows.Forms.Button();
            this.pagamentoCrediario = new System.Windows.Forms.Button();
            this.panelCredito = new System.Windows.Forms.Panel();
            this.radioButtonParceladoAdm = new System.Windows.Forms.RadioButton();
            this.radioButtonParceladoLoja = new System.Windows.Forms.RadioButton();
            this.labelNumeroParcelas = new System.Windows.Forms.Label();
            this.radioButtonParcelado = new System.Windows.Forms.RadioButton();
            this.radioButtonAvista = new System.Windows.Forms.RadioButton();
            this.numericUpDownNumeroParcelas = new System.Windows.Forms.NumericUpDown();
            this.panelCrediario = new System.Windows.Forms.Panel();
            this.panelCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(167, 12);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 20);
            this.valor.TabIndex = 0;
            this.valor.Text = "01,00";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor para Pagamento";
            // 
            // radioButtonDebito
            // 
            this.radioButtonDebito.AutoSize = true;
            this.radioButtonDebito.Checked = true;
            this.radioButtonDebito.Location = new System.Drawing.Point(58, 58);
            this.radioButtonDebito.Name = "radioButtonDebito";
            this.radioButtonDebito.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDebito.TabIndex = 2;
            this.radioButtonDebito.TabStop = true;
            this.radioButtonDebito.Text = "Debito";
            this.radioButtonDebito.UseVisualStyleBackColor = true;
            // 
            // radioButtonCredito
            // 
            this.radioButtonCredito.AutoSize = true;
            this.radioButtonCredito.Location = new System.Drawing.Point(120, 58);
            this.radioButtonCredito.Name = "radioButtonCredito";
            this.radioButtonCredito.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCredito.TabIndex = 3;
            this.radioButtonCredito.Text = "Credito";
            this.radioButtonCredito.UseVisualStyleBackColor = true;
            // 
            // radioButtonCrediario
            // 
            this.radioButtonCrediario.AutoSize = true;
            this.radioButtonCrediario.Location = new System.Drawing.Point(184, 58);
            this.radioButtonCrediario.Name = "radioButtonCrediario";
            this.radioButtonCrediario.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCrediario.TabIndex = 4;
            this.radioButtonCrediario.Text = "Crediario";
            this.radioButtonCrediario.UseVisualStyleBackColor = true;
            // 
            // pagamentoDebito
            // 
            this.pagamentoDebito.Location = new System.Drawing.Point(0, 233);
            this.pagamentoDebito.Name = "pagamentoDebito";
            this.pagamentoDebito.Size = new System.Drawing.Size(109, 23);
            this.pagamentoDebito.TabIndex = 5;
            this.pagamentoDebito.Text = "Pagamento débito";
            this.pagamentoDebito.UseVisualStyleBackColor = true;
            this.pagamentoDebito.Click += new System.EventHandler(this.PagamentoDebito);
            // 
            // pagamentoCredito
            // 
            this.pagamentoCredito.Location = new System.Drawing.Point(112, 233);
            this.pagamentoCredito.Name = "pagamentoCredito";
            this.pagamentoCredito.Size = new System.Drawing.Size(109, 23);
            this.pagamentoCredito.TabIndex = 6;
            this.pagamentoCredito.Text = "Pagamento Credito";
            this.pagamentoCredito.UseVisualStyleBackColor = true;
            // 
            // pagamentoCrediario
            // 
            this.pagamentoCrediario.Location = new System.Drawing.Point(225, 233);
            this.pagamentoCrediario.Name = "pagamentoCrediario";
            this.pagamentoCrediario.Size = new System.Drawing.Size(119, 23);
            this.pagamentoCrediario.TabIndex = 7;
            this.pagamentoCrediario.Text = "Pagamento Crediario";
            this.pagamentoCrediario.UseVisualStyleBackColor = true;
            // 
            // panelCredito
            // 
            this.panelCredito.Controls.Add(this.radioButtonParceladoAdm);
            this.panelCredito.Controls.Add(this.radioButtonParceladoLoja);
            this.panelCredito.Controls.Add(this.labelNumeroParcelas);
            this.panelCredito.Controls.Add(this.radioButtonParcelado);
            this.panelCredito.Controls.Add(this.radioButtonAvista);
            this.panelCredito.Controls.Add(this.numericUpDownNumeroParcelas);
            this.panelCredito.Location = new System.Drawing.Point(12, 102);
            this.panelCredito.Name = "panelCredito";
            this.panelCredito.Size = new System.Drawing.Size(166, 105);
            this.panelCredito.TabIndex = 8;
            // 
            // radioButtonParceladoAdm
            // 
            this.radioButtonParceladoAdm.AutoSize = true;
            this.radioButtonParceladoAdm.Location = new System.Drawing.Point(7, 81);
            this.radioButtonParceladoAdm.Name = "radioButtonParceladoAdm";
            this.radioButtonParceladoAdm.Size = new System.Drawing.Size(94, 17);
            this.radioButtonParceladoAdm.TabIndex = 5;
            this.radioButtonParceladoAdm.Text = "Administradora";
            this.radioButtonParceladoAdm.UseVisualStyleBackColor = true;
            // 
            // radioButtonParceladoLoja
            // 
            this.radioButtonParceladoLoja.AutoSize = true;
            this.radioButtonParceladoLoja.Checked = true;
            this.radioButtonParceladoLoja.Location = new System.Drawing.Point(7, 58);
            this.radioButtonParceladoLoja.Name = "radioButtonParceladoLoja";
            this.radioButtonParceladoLoja.Size = new System.Drawing.Size(96, 17);
            this.radioButtonParceladoLoja.TabIndex = 4;
            this.radioButtonParceladoLoja.TabStop = true;
            this.radioButtonParceladoLoja.Text = "Parcelado Loja";
            this.radioButtonParceladoLoja.UseVisualStyleBackColor = true;
            // 
            // labelNumeroParcelas
            // 
            this.labelNumeroParcelas.AutoSize = true;
            this.labelNumeroParcelas.Location = new System.Drawing.Point(3, 33);
            this.labelNumeroParcelas.Name = "labelNumeroParcelas";
            this.labelNumeroParcelas.Size = new System.Drawing.Size(103, 13);
            this.labelNumeroParcelas.TabIndex = 3;
            this.labelNumeroParcelas.Text = "Número de Parcelas";
            // 
            // radioButtonParcelado
            // 
            this.radioButtonParcelado.AutoSize = true;
            this.radioButtonParcelado.Location = new System.Drawing.Point(84, 3);
            this.radioButtonParcelado.Name = "radioButtonParcelado";
            this.radioButtonParcelado.Size = new System.Drawing.Size(73, 17);
            this.radioButtonParcelado.TabIndex = 2;
            this.radioButtonParcelado.Text = "Parcelado";
            this.radioButtonParcelado.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvista
            // 
            this.radioButtonAvista.AutoSize = true;
            this.radioButtonAvista.Location = new System.Drawing.Point(12, 3);
            this.radioButtonAvista.Name = "radioButtonAvista";
            this.radioButtonAvista.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAvista.TabIndex = 1;
            this.radioButtonAvista.Text = "Avista";
            this.radioButtonAvista.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNumeroParcelas
            // 
            this.numericUpDownNumeroParcelas.Location = new System.Drawing.Point(122, 31);
            this.numericUpDownNumeroParcelas.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownNumeroParcelas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumeroParcelas.Name = "numericUpDownNumeroParcelas";
            this.numericUpDownNumeroParcelas.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownNumeroParcelas.TabIndex = 0;
            this.numericUpDownNumeroParcelas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // panelCrediario
            // 
            this.panelCrediario.Location = new System.Drawing.Point(184, 102);
            this.panelCrediario.Name = "panelCrediario";
            this.panelCrediario.Size = new System.Drawing.Size(150, 105);
            this.panelCrediario.TabIndex = 9;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.panelCrediario);
            this.Controls.Add(this.panelCredito);
            this.Controls.Add(this.pagamentoCrediario);
            this.Controls.Add(this.pagamentoCredito);
            this.Controls.Add(this.pagamentoDebito);
            this.Controls.Add(this.radioButtonCrediario);
            this.Controls.Add(this.radioButtonCredito);
            this.Controls.Add(this.radioButtonDebito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valor);
            this.Name = "Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.panelCredito.ResumeLayout(false);
            this.panelCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDebito;
        private System.Windows.Forms.RadioButton radioButtonCredito;
        private System.Windows.Forms.RadioButton radioButtonCrediario;
        private System.Windows.Forms.Button pagamentoDebito;
        private System.Windows.Forms.Button pagamentoCredito;
        private System.Windows.Forms.Button pagamentoCrediario;
        private System.Windows.Forms.Panel panelCredito;
        private System.Windows.Forms.RadioButton radioButtonParceladoAdm;
        private System.Windows.Forms.RadioButton radioButtonParceladoLoja;
        private System.Windows.Forms.Label labelNumeroParcelas;
        private System.Windows.Forms.RadioButton radioButtonParcelado;
        private System.Windows.Forms.RadioButton radioButtonAvista;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroParcelas;
        private System.Windows.Forms.Panel panelCrediario;
    }
}
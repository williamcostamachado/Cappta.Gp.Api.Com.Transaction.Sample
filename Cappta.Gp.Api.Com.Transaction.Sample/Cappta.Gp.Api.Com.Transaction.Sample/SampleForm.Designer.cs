namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    partial class SampleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleForm));
            this.panelFormPrincipal = new System.Windows.Forms.Panel();
            this.ExecutarOperacao = new System.Windows.Forms.Button();
            this.nsu = new System.Windows.Forms.TextBox();
            this.labelNSU = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFinalDate = new System.Windows.Forms.Label();
            this.labelDateInit = new System.Windows.Forms.Label();
            this.finalDate = new System.Windows.Forms.MaskedTextBox();
            this.initialDate = new System.Windows.Forms.MaskedTextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfiguracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcoesAdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReimpressaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PinpadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preautorizacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ConciliacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelFormPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormPrincipal
            // 
            this.panelFormPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormPrincipal.Controls.Add(this.ExecutarOperacao);
            this.panelFormPrincipal.Controls.Add(this.nsu);
            this.panelFormPrincipal.Controls.Add(this.labelNSU);
            this.panelFormPrincipal.Controls.Add(this.cnpj);
            this.panelFormPrincipal.Controls.Add(this.label2);
            this.panelFormPrincipal.Controls.Add(this.labelFinalDate);
            this.panelFormPrincipal.Controls.Add(this.labelDateInit);
            this.panelFormPrincipal.Controls.Add(this.finalDate);
            this.panelFormPrincipal.Controls.Add(this.initialDate);
            this.panelFormPrincipal.Controls.Add(this.dgv);
            this.panelFormPrincipal.Controls.Add(this.label1);
            this.panelFormPrincipal.Controls.Add(this.panelMenu);
            this.panelFormPrincipal.Controls.Add(this.pictureBoxLogo);
            this.panelFormPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelFormPrincipal.Name = "panelFormPrincipal";
            this.panelFormPrincipal.Size = new System.Drawing.Size(784, 561);
            this.panelFormPrincipal.TabIndex = 0;
            // 
            // ExecutarOperacao
            // 
            this.ExecutarOperacao.Location = new System.Drawing.Point(494, 63);
            this.ExecutarOperacao.Name = "ExecutarOperacao";
            this.ExecutarOperacao.Size = new System.Drawing.Size(136, 23);
            this.ExecutarOperacao.TabIndex = 12;
            this.ExecutarOperacao.Text = "Pesquisar";
            this.ExecutarOperacao.UseVisualStyleBackColor = true;
            this.ExecutarOperacao.Click += new System.EventHandler(this.ExecutarOperacao_Click);
            // 
            // nsu
            // 
            this.nsu.Location = new System.Drawing.Point(220, 485);
            this.nsu.Name = "nsu";
            this.nsu.Size = new System.Drawing.Size(64, 20);
            this.nsu.TabIndex = 11;
            // 
            // labelNSU
            // 
            this.labelNSU.AutoSize = true;
            this.labelNSU.Location = new System.Drawing.Point(173, 487);
            this.labelNSU.Name = "labelNSU";
            this.labelNSU.Size = new System.Drawing.Size(30, 13);
            this.labelNSU.TabIndex = 10;
            this.labelNSU.Text = "NSU";
            // 
            // cnpj
            // 
            this.cnpj.AutoCompleteCustomSource.AddRange(new string[] {
            "08476665000188",
            "71053157000123",
            "30570051000110",
            "34555898000186",
            "42724382000146",
            "38100728000168",
            "40841182000148"});
            this.cnpj.FormattingEnabled = true;
            this.cnpj.Items.AddRange(new object[] {
            "30570051000110",
            "34555898000186",
            "38100728000168",
            "42724382000146",
            "71053157000123"});
            this.cnpj.Location = new System.Drawing.Point(46, 484);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(121, 21);
            this.cnpj.TabIndex = 9;
            this.cnpj.Text = "08476665000188";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cnpj";
            // 
            // labelFinalDate
            // 
            this.labelFinalDate.AutoSize = true;
            this.labelFinalDate.Location = new System.Drawing.Point(156, 527);
            this.labelFinalDate.Name = "labelFinalDate";
            this.labelFinalDate.Size = new System.Drawing.Size(23, 13);
            this.labelFinalDate.TabIndex = 7;
            this.labelFinalDate.Text = "Até";
            // 
            // labelDateInit
            // 
            this.labelDateInit.AutoSize = true;
            this.labelDateInit.Location = new System.Drawing.Point(17, 527);
            this.labelDateInit.Name = "labelDateInit";
            this.labelDateInit.Size = new System.Drawing.Size(21, 13);
            this.labelDateInit.TabIndex = 6;
            this.labelDateInit.Text = "De";
            // 
            // finalDate
            // 
            this.finalDate.Location = new System.Drawing.Point(220, 522);
            this.finalDate.Mask = "0000/00/00";
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(64, 20);
            this.finalDate.TabIndex = 5;
            this.finalDate.Text = "20180201";
            this.finalDate.ValidatingType = typeof(System.DateTime);
            // 
            // initialDate
            // 
            this.initialDate.Location = new System.Drawing.Point(69, 522);
            this.initialDate.Mask = "0000/00/00";
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(64, 20);
            this.initialDate.TabIndex = 4;
            this.initialDate.Text = "20180201";
            this.initialDate.ValidatingType = typeof(System.DateTime);
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 95);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(760, 365);
            this.dgv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "API de Transações/ Portal de Vendas";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Location = new System.Drawing.Point(56, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(721, 46);
            this.panelMenu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfiguracaoToolStripMenuItem,
            this.PagamentoToolStripMenuItem,
            this.opcoesAdmToolStripMenuItem,
            this.OutrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConfiguracaoToolStripMenuItem
            // 
            this.ConfiguracaoToolStripMenuItem.Name = "ConfiguracaoToolStripMenuItem";
            this.ConfiguracaoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ConfiguracaoToolStripMenuItem.Text = "Configuração";
            this.ConfiguracaoToolStripMenuItem.Click += new System.EventHandler(this.ConfiguracaoToolStripMenuItem_Click);
            // 
            // PagamentoToolStripMenuItem
            // 
            this.PagamentoToolStripMenuItem.Name = "PagamentoToolStripMenuItem";
            this.PagamentoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.PagamentoToolStripMenuItem.Text = "Pagamento";
            this.PagamentoToolStripMenuItem.Click += new System.EventHandler(this.PagamentoToolStripMenuItem_Click);
            // 
            // opcoesAdmToolStripMenuItem
            // 
            this.opcoesAdmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelamentoToolStripMenuItem,
            this.ReimpressaoToolStripMenuItem});
            this.opcoesAdmToolStripMenuItem.Name = "opcoesAdmToolStripMenuItem";
            this.opcoesAdmToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.opcoesAdmToolStripMenuItem.Text = "Opções administrativas";
            // 
            // CancelamentoToolStripMenuItem
            // 
            this.CancelamentoToolStripMenuItem.Name = "CancelamentoToolStripMenuItem";
            this.CancelamentoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.CancelamentoToolStripMenuItem.Text = "Cancelamento";
            // 
            // ReimpressaoToolStripMenuItem
            // 
            this.ReimpressaoToolStripMenuItem.Name = "ReimpressaoToolStripMenuItem";
            this.ReimpressaoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ReimpressaoToolStripMenuItem.Text = "Reimpessão";
            // 
            // OutrosToolStripMenuItem
            // 
            this.OutrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PinpadToolStripMenuItem,
            this.ticketCarToolStripMenuItem,
            this.preautorizacaoToolStripMenuItem,
            this.toolStripSeparator5,
            this.ConciliacaoToolStripMenuItem});
            this.OutrosToolStripMenuItem.Name = "OutrosToolStripMenuItem";
            this.OutrosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.OutrosToolStripMenuItem.Text = "Outros";
            // 
            // PinpadToolStripMenuItem
            // 
            this.PinpadToolStripMenuItem.Name = "PinpadToolStripMenuItem";
            this.PinpadToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.PinpadToolStripMenuItem.Text = "Pinpad";
            // 
            // ticketCarToolStripMenuItem
            // 
            this.ticketCarToolStripMenuItem.Name = "ticketCarToolStripMenuItem";
            this.ticketCarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ticketCarToolStripMenuItem.Text = "Tiket Kar";
            // 
            // preautorizacaoToolStripMenuItem
            // 
            this.preautorizacaoToolStripMenuItem.Name = "preautorizacaoToolStripMenuItem";
            this.preautorizacaoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.preautorizacaoToolStripMenuItem.Text = "Pre-Autorização";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            // 
            // ConciliacaoToolStripMenuItem
            // 
            this.ConciliacaoToolStripMenuItem.Name = "ConciliacaoToolStripMenuItem";
            this.ConciliacaoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ConciliacaoToolStripMenuItem.Text = "Conciliação";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Cappta.Gp.Api.Com.Transaction.Sample.Properties.Resources.cappta;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(52, 47);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelFormPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelFormPrincipal.ResumeLayout(false);
            this.panelFormPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfiguracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcoesAdmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReimpressaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OutrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PinpadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preautorizacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ConciliacaoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFinalDate;
        private System.Windows.Forms.Label labelDateInit;
        private System.Windows.Forms.MaskedTextBox finalDate;
        private System.Windows.Forms.MaskedTextBox initialDate;
        private System.Windows.Forms.ComboBox cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nsu;
        private System.Windows.Forms.Label labelNSU;
        private System.Windows.Forms.Button ExecutarOperacao;
    }
}


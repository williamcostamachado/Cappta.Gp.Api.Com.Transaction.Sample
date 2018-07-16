using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Cappta.Gp.Api.Conciliacao.Aplication;
using System;
using System.Windows.Forms;

namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    public partial class SampleForm : Form
    {
        private string NextUrl;

        private string PreviousUrl;

        private TransactionProvider transactionProvider;

        public SampleForm()
        {
            InitializeComponent();
            this.transactionProvider = new TransactionProvider(new Connection(), new TransactionRequest());
        }

        private void ConfiguracaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configuracao = new Configuracao();
            configuracao.Show();
        }

        private void PagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pagamento = new Pagamento();
            pagamento.Show();
        }

        private TransactionFilter CreateFilter()
        {
            return new TransactionFilter()
            {
                AdministrativeCode = codigoAdm.Text,
                Pdv = (int)pdv.Value,
                Cnpj = cnpj.Text,
                UniqueSequentialNumber = nsu.Text,
                FinalDate = finalDate.Text,
                InitialDate = initialDate.Text             
            };
        }

        private void ExecutarOperacao_Click(object sender, EventArgs e)
        {           
            var filter = this.CreateFilter();
            
            var response = this.transactionProvider.FindByFilter(filter);

            this.NextUrl = response.Next;
  
            dgv.DataSource = response.Results;
        }

        private void Next_Click(object sender, EventArgs e)
        {         
            dgv.DataSource = this.transactionProvider.FindByUrl(NextUrl).Results;

            this.PreviousUrl = this.transactionProvider.FindByUrl(NextUrl).Previous;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            dgv.DataSource = this.transactionProvider.FindByUrl(PreviousUrl).Results;
        }
    }
}

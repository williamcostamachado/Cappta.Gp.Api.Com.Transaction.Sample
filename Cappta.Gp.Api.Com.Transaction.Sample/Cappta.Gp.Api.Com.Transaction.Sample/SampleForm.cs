using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    public partial class SampleForm : Form
    {
        private string NextUrl;

        private string PreviousUrl;

        public SampleForm()
        {
            InitializeComponent();
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
            var transactionProvider = new TransactionProvider();
            var filter = this.CreateFilter();
            
            var response = transactionProvider.FindByFilter(filter);

            this.NextUrl = response.Next;
  
            dgv.DataSource = response.Results;
        }

        private void Next_Click(object sender, EventArgs e)
        {         
            var transactionProvider = new TransactionProvider();
            dgv.DataSource = transactionProvider.FindNext(NextUrl).Results;

            this.PreviousUrl = transactionProvider.FindNext(NextUrl).Previous;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            var transactionProvider = new TransactionProvider();
            dgv.DataSource = transactionProvider.FindPrevious(PreviousUrl).Results;
        }
    }
}

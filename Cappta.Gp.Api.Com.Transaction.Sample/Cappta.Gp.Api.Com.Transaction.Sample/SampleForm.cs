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
            var provider = new TransactionProvider();
            var filter = this.CreateFilter();
            next.Visible = true;

            var response = provider.GetSales(filter);

            this.NextUrl = response.Next;
  
            dgv.DataSource = response.Results;
        }

        private void Next_Click(object sender, EventArgs e)
        {         
            var provider = new TransactionProvider();
            dgv.DataSource = provider.GetNext(NextUrl).Results;

            this.PreviousUrl = provider.GetNext(NextUrl).Previous;
            previous.Visible = true;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            var provider = new TransactionProvider();
            dgv.DataSource = provider.GetPrevious(PreviousUrl).Results;
        }
    }
}

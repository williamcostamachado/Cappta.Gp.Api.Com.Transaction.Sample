using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    public partial class SampleForm : Form
    {
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
                Cnpj = cnpj.Text,
                Nsu = nsu.Text,
                FinalDate = Convert.ToDateTime(initialDate.Text),
                InitialDate = Convert.ToDateTime(finalDate.Text)
            };
        }

        private void ExecutarOperacao_Click(object sender, EventArgs e)
        {
            var provider = new TransactionProvider();
            var filter = this.CreateFilter();

            dgv.DataSource = provider.GetSales(filter).ToList();
        }
    }
}

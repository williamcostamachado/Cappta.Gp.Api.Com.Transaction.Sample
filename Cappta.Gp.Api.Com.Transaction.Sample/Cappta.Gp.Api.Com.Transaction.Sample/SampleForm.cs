using Cappta.Gp.Api.Com.Transaction.Domain;
using System;
using System.Windows.Forms;

namespace Cappta.Gp.Api.Com.Transaction.Sample
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private void FormTef_Load(object sender, EventArgs e)
        {
           

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
                Cnpj = cnpj.SelectedItem.ToString(),
                Nsu = nsu.Text,
                FinalDate = Convert.ToDateTime(finalDate.Text),
                InitialDate = Convert.ToDateTime(initialDate.Text)
            };
        }

        private void ExecutarOperacao_Click(object sender, EventArgs e)
        {
            
            var filter = this.CreateFilter();
            
        }
    }
}

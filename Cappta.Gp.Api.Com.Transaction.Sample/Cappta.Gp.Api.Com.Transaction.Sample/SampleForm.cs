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
    }
}

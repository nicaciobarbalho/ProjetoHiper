using Chronos.Windows.Library.CO;
using System;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormListarProduto : Form
    {
        public FormListarProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormListarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProdutos.DataSource = new ProdutoCO().Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível listar os clientes.\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
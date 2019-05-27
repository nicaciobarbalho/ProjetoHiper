using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.CO;
using System;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string msgErro = "";

            var produto = new ProdutoBO();
            produto.Nome = txtNome.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.Sincronizar = true;

            var sucesso = new ProdutoCO().Adicionar(produto, out msgErro);

            if (sucesso)
            {
                MessageBox.Show("Produto adicionado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show($"Não foi possível adicionar o produto!\n{msgErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
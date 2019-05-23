using System;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadastrarCliente = new FormCadastroCliente();
            formCadastrarCliente.ShowDialog();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCadastrarProduto = new FormCadastroProduto();
            formCadastrarProduto.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formListarCliente = new FormListarCliente();
            formListarCliente.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formListarProdutos = new FormListarProduto();
            formListarProdutos.ShowDialog();
        }
        
        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSincronizacao = new FormSincronizacao();
            formSincronizacao.ShowDialog();
        }
    }
}
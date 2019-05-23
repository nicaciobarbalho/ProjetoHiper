using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.CO;
using System;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string msgErro = "";

            var cliente = new ClienteBO();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Bairro = txtCidade.Text;
            cliente.Cidade = txtBairro.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.NumeroEndereco = txtNumeroEndereco.Text;
            cliente.Uf = txtEstado.Text;
            cliente.Sincronizar = true;

            var sucesso = new ClienteCO().Adicionar(cliente, out msgErro);

            if (sucesso)
            {
                MessageBox.Show("Cliente adicionado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show($"Não foi possível adicionar o cliente!\n{msgErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
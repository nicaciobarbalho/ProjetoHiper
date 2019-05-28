using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.CO;
using Chronos.Windows.Library.CO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormSincronizacao : Form
    {
        public delegate void AtualizarLabelCallback(string text);

        public delegate void AtualizarBotaFechar();

        public FormSincronizacao()
        {
            InitializeComponent();
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSincronizacao_Load(object sender, EventArgs e)
        {
            btnFechar.Enabled = false;

            Task.Run(() => {

                string msgErro = "";

                lblStatus.Invoke(new AtualizarLabelCallback(this.AtualizarLabel), "Sincronizando produtos...");

                var sincronizouProdutos = new ProdutoCO().SincronizarProdutos(out msgErro);

                if (!sincronizouProdutos)
                {
                    lblStatus.Invoke(new AtualizarLabelCallback(this.AtualizarLabel), $"Erro na sincronização de produtos: {msgErro}");
                }
                
                lblStatus.Invoke(new AtualizarLabelCallback(this.AtualizarLabel), "Sincronizando clientes...");

                var sincronizouClientes = new ClienteCO().SincronizarClientes(out msgErro);

                if (!sincronizouClientes)
                {
                    lblStatus.Invoke(new AtualizarLabelCallback(this.AtualizarLabel), $"Erro na sincronização de clientes: {msgErro}");
                }

                var sincronizouPedidos = new PedidoCO().SincronizarPedidos(out msgErro);

                if (!sincronizouPedidos)
                {
                    lblStatus.Invoke(new AtualizarLabelCallback(this.AtualizarLabel), $"Erro na sincronização de pedidos: {msgErro}");
                }

                lblStatus.Invoke(new AtualizarLabelCallback(this.AtualizarLabel), "Finalizado :)");

                btnFechar.Invoke(new AtualizarBotaFechar(this.HabilitarBotaFechar));

            });
            
        }

        private void AtualizarLabel(string texto)
        {
            lblStatus.Text = texto;
        }

        private void HabilitarBotaFechar()
        {
            btnFechar.Enabled = true;
        }

    }
}

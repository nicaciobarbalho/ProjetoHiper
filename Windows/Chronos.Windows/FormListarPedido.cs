using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.CO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormListarPedido : Form
    {
        public FormListarPedido()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListarPedido_Load(object sender, EventArgs e)
        {
            try
            {
       
                var results = (from p in new PedidoCO().Listar().AsParallel()
                               join c in new ClienteCO().Listar().AsParallel()
                                  on p.ClienteId equals c.Id
                                  join s in new PedidoSituacaoCO().Listar().AsParallel()
                                   on p.PedidoSituacaoId equals s.Id
                               select new
                               {
                                   p.Id,
                                   c.Nome,
                                   Situacao = s.Descricao,
                                   p.ValorBruto,
                                   p.ValorDesconto,
                                   p.ValorLiquido
                               });

                var x = results.ToList().OrderByDescending(o => o.Id).ToList();
                this.grvPedidos.DataSource = x;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível listar os clientes.\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}

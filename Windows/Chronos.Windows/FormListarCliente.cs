using Chronos.Windows.Library.CO;
using System;
using System.Windows.Forms;

namespace Chronos.Windows
{
    public partial class FormListarCliente : Form
    {
        public FormListarCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void FormListarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = new ClienteCO().Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível listar os clientes.\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
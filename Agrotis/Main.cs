using Agrotis.Cadastro;
using System;
using Agrotis.Pedidos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agrotis.Pedidos;

namespace Agrotis
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientes frm = new CadastroClientes();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProdutos frm = new CadastroProdutos();
            frm.Show();
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos.Pedidos frm = new Pedidos.Pedidos();
            frm.Show();
        }
    }
}

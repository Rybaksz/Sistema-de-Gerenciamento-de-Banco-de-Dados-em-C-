using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_12_Vitor_Relac_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Clientes tl_Clientes = new frm_Clientes();
            tl_Clientes.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_produtos tl_Produtos = new frm_produtos();
            tl_Produtos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Vendas tl_Vendas = new frm_Vendas();
            tl_Vendas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Clientes tl_Clientes = new frm_Clientes();
            tl_Clientes.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos tl_Produtos = new frm_produtos();
            tl_Produtos.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vendas tl_Vendas = new frm_Vendas();
            tl_Vendas.Show();
        }
    }
}

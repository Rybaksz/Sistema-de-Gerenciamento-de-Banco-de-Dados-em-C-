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
    public partial class frm_Vendas : Form
    {
        public frm_Vendas()
        {
            InitializeComponent();
        }

        private void vENDASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vENDASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rELACIONAMENTOS_200DataSet);

        }

        private void frm_Vendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rELACIONAMENTOS_200DataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDASTableAdapter.Fill(this.rELACIONAMENTOS_200DataSet.VENDAS);

        }
    }
}

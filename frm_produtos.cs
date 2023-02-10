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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void pRODUTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUTOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rELACIONAMENTOS_200DataSet);

        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rELACIONAMENTOS_200DataSet.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter.Fill(this.rELACIONAMENTOS_200DataSet.PRODUTOS);

        }
    }
}

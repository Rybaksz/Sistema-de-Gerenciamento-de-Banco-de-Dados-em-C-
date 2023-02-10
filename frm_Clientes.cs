using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_12_Vitor_Relac_1000
{
    public partial class frm_Clientes : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0625246W10-1;Initial Catalog=RELACIONAMENTOS_200;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;


















        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            Carregarlista();

            // TODO: esta linha de código carrega dados na tabela 'rELACIONAMENTOS_200DataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            //this.cLIENTESTableAdapter.Fill(this.rELACIONAMENTOS_200DataSet.CLIENTES);


        }
        private void Carregarlista()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6 .Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Clientes";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            { 
                while(dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                    listBox4.Items.Add(dr[3].ToString());
                    listBox5.Items.Add(dr[4].ToString());
                    listBox6.Items.Add(dr[5].ToString());


                }

                conn.Close();
            
            
            }






        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rELACIONAMENTOS_200DataSet);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox; 
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;

              
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex; ; ;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;

              
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox; //o l vai representar o 2 onde vai setar toda linha do banco de dados segundo e vai mostrar no listbox 
            if(l.SelectedIndex !=-1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;

                textBox1.Text = listBox1.SelectedItem.ToString();
                textBox2.Text = listBox2.SelectedItem.ToString();
                textBox3.Text = listBox3.SelectedItem.ToString();
                textBox4.Text = listBox4.SelectedItem.ToString();
                textBox5.Text = listBox5.SelectedItem.ToString();
                textBox6.Text = listBox6.SelectedItem.ToString();

            }











        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox; 
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;

            }

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox; 
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;

            }

        }

        private void button2_Click(object sender, EventArgs e)

        {

            if (DialogResult.Yes == MessageBox.Show("Deseja Salvar?", "CONFIRMAÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                conn.Open();
            comando.CommandText = "insert into Clientes(nome,endereco,datanascimento,telefone,email) " + "values ('" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            Carregarlista();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Focus();
                MessageBox.Show("Dados Salvos", "Operação Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Dados Salvos", "Operação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }














        }

        private void button3_Click(object sender, EventArgs e)

        {

            if (DialogResult.Yes == MessageBox.Show("Deseja Alterar?", "CONFIRMAÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {



                conn.Open();
            comando.CommandText = "update Clientes set nome ='"+textBox2.Text +"',endereco = '"+textBox3.Text +"',datanascimento = '"+textBox4.Text +"',telefone ='"+textBox5.Text +"', email ='"+ textBox6.Text +"' where codigo = '"+listBox1.SelectedItem.ToString() +"'";
            comando.ExecuteNonQuery();
            conn.Close();
            Carregarlista();
                MessageBox.Show("Dados Alterados", "Operação Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                MessageBox.Show("Dados Não Alterados", "Operação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }









        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (DialogResult.Yes == MessageBox.Show("Deseja Excluir?","CONFIRMAÇÂO",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2))
                {
               


            conn.Open();
            comando.CommandText = "delete from Clientes where codigo = '" + textBox1.Text+ "'";
            comando.ExecuteNonQuery();
            conn.Close();
            Carregarlista();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Focus();
                MessageBox.Show("Dados Excluídos", "Operação Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            else
            {
                MessageBox.Show("Dados Não Excluídos", "Operação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_CARINOR_2._0
{
    public partial class FPedidos : Form
    {
        public FPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int f = dataGridView1.Rows.Add();
            //dataGridView1.Rows[f].Cells[0].Value = textBox1Idpedido.Text;
            //dataGridView1.Rows[f].Cells[1].Value = textBox1cantidad.Text;
            //dataGridView1.Rows[f].Cells[2].Value = textBox2precio.Text;
            //dataGridView1.Rows[f].Cells[3].Value = textBox3cliente.Text;
            //dataGridView1.Rows[f].Cells[4].Value = textBox1destino.Text;
            //textBox1Idpedido.Text = " ";
            //textBox1cantidad.Text = " ";
            //textBox2precio.Text = " ";
            //textBox3cliente.Text = " ";
            //textBox1destino.Text = " ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1Regresar_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string borrar = "DELETE FROM CRUD WHERE ID=" + textBox1Idpedido.Text;

         // if (bd.executecommand(borrar));
         //{messagebox.show(logrado)
         //datagridview1.datasource = bd.selectdatatable("select" from crud")};
        }

        private void FPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}


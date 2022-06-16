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
            int f = dataGridView1.Rows.Add();
            dataGridView1.Rows[f].Cells[0].Value = textBox1cantidad.Text;
            dataGridView1.Rows[f].Cells[1].Value = textBox2precio.Text;
            dataGridView1.Rows[f].Cells[2].Value = textBox3cliente.Text;
            textBox1cantidad.Text = " ";
            textBox2precio.Text = " ";
            textBox3cliente.Text = " ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1Regresar_Click(object sender, EventArgs e)
        {
           // this.Close();
        }
    }
}


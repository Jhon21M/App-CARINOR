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
    public partial class FBodega : Form
    {
        public FBodega()
        {
            InitializeComponent();
        }

        private void FBodega_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1guardar_Click(object sender, EventArgs e)
        {
            int f = DGTBodega.Rows.Add();

            DGTBodega.Rows[f].Cells[0].Value = tbxPRODUCTO.Text;
            DGTBodega.Rows[f].Cells[1].Value = tbxMARCA.Text;
            DGTBodega.Rows[f].Cells[2].Value = tbxPRECIO.Text;
            DGTBodega.Rows[f].Cells[3].Value = tbxCADUCIDAD.Text;
            tbxPRODUCTO.Text = " ";
            tbxMARCA.Text = " ";
            tbxPRECIO.Text = " ";
            tbxCADUCIDAD.Text = " ";
            
         
        }
    }
}

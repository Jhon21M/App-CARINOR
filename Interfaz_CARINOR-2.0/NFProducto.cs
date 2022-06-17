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
    public partial class NFProducto : Form
    {
        MProductos objP = new MProductos();
        public NFProducto()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {
            
        }

        public void TDatos()
        {
            DGTMostrarP.DataSource = objP.MostrarDProduct();
               
        }

    }
}

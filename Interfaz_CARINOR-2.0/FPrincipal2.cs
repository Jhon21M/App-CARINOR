using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Interfaz_CARINOR_2._0
{
    public partial class FPrincipal2 : Form
    {
        public  FPrincipal2()
        {
            InitializeComponent();
            //Inicializaciòn();
        }
        private void EPanel()
        {
            if (PAdminist.Visible == true)
                PAdminist.Visible = false;
         
         
     

           
        }

       


        private void FPrincipal2_Load(object sender, EventArgs e)
        {

            EPanel();
            BUbicacio();
            PSubMenu.Size = new Size(177, 417);
            PSoporte.Visible = false;
            
        }
        private Form activeform = null;
        private void AbrirFormularios(Form H)
        {
            if (activeform != null)
                activeform.Close();
            activeform = H;
            H.TopLevel = false;
            H.FormBorderStyle = FormBorderStyle.None;
            H.Dock = DockStyle.Fill;
            PPrincipalF.Controls.Add(H);
            PPrincipalF.Tag = H;
            H.BringToFront();
            H.Show();

        }
        private void BUbicacio()
        {
            BAdminist.Location = new Point(0, 0);
            BPedidos.Location = new Point(0, 50);
            BGastos.Location = new Point(3, 100);
            BEstadist.Location = new Point(0, 149);
        }

       

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (PSoporte.Visible == true)
            { 
                PSoporte.Visible = false;
            }
            else
            {
                
                PSoporte.Visible = true;
                PSoporte.Size = new Size(151, 97);
                PSoporte.Location =new Point(36,3);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {
            

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FPedidos());
            EPanel();
            BUbicacio();

            PAdminist.Visible = false;   

        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void BAdminist_Click(object sender, EventArgs e)
        {
          
               
           

                if (PAdminist.Visible == true)
                {
                    EPanel();
                    BUbicacio();
                }
                else
                {
                    PAdminist.Visible = true;
                    PAdminist.Size = new Size(172, 136); 
                }
                BAdminist.Location = new Point(0, 0);
                PAdminist.Location = new Point(0, 49);
                BPedidos.Location = new Point(0, 190);
                BGastos.Location = new Point(0, 230);
                BEstadist.Location = new Point(0, 270);


                if (PAdminist.Visible == false)
                {
                    BUbicacio();
              }

             
          
        }

        private void BPago_Click(object sender, EventArgs e)
        {

            PAdminist.Visible = false;
            
        }

        private void BGastos_Click(object sender, EventArgs e)
        {
            
                PAdminist.Visible = false;
            {
                EPanel();
                BUbicacio();
   


}
        
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PPedidos_Click(object sender, EventArgs e)
        {

        }

        private void BEstadist_Click(object sender, EventArgs e)
        {
           
                PAdminist.Visible = false;
   
           
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FClientes());
            EPanel();
            BUbicacio();
            
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FBodega());
            EPanel();
            BUbicacio();

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FProductoss());
            EPanel();
            BUbicacio();
        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void PPago_Click(object sender, EventArgs e)
        {

        }
    
        private void BCerrarSession_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();


        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton13_Click_1(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void PSoporte_Click(object sender, EventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
           
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void bunifuGradientPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormCani(object formcani)
        {
            if (this.PPrincipalF.Controls.Count > 0)
                this.PPrincipalF.Controls.RemoveAt(0);
            Form cn = formcani as Form;
            cn.TopLevel = false;
            cn.Dock = DockStyle.Fill;
            this.PPrincipalF.Controls.Add(cn);
            this.PPrincipalF.Tag = cn;
            cn.Show();
        }

        private void TXTCAN_Click(object sender, EventArgs e)
        {
            AbrirFormCani(new portada());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new NFProducto());
            EPanel();
            BUbicacio();

        }

        private void PGastos_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Eterno_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Button4_Click(null, e);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

               
        private void clouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new principal());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new noticias());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new tienda());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new reguistro());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new galeria());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ranking());
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
                
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }
    }
}

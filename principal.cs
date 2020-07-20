using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace Eterno_Launcher
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
           
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void botonstart_Click(object sender, EventArgs e)
        {
            Process.Start("Dofus.exe");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dofuseterno.com/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2ProgressBar1.Value <100)
            guna2ProgressBar1.Value++;
            if (guna2ProgressBar1.Value == 100)
                timer1.Enabled = false;
        }

    }
}

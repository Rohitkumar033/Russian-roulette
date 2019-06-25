using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_roulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
                 //Calling Load function from Game Class
                btn_load.Enabled = false; // Disabling Load button
                btn_spin.Enabled = true;
                btn_shoot.Enabled = false;
                btn_shootaway.Enabled = false;

            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

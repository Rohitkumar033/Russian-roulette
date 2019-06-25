using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

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
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.boot);
            snd.Play();
                 //blow coding for load button//
                btn_load.Enabled = false; // Disabling Load button
                btn_spin.Enabled = true;
                btn_shoot.Enabled = false;
                btn_shootaway.Enabled = false;

            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_spin_Click(object sender, EventArgs e)
        {
            //Calling Spin function from Game Class
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            //Calling Shoot function from Game Class
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
        }

        private void Btn_shootaway_Click(object sender, EventArgs e)
        {
            //Calling Shoot Away function from Game Class
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

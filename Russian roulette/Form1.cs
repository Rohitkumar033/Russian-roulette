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
            //coding for sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.loads);
            snd.Play();
            //blow coding for load button//
            btn_load.Enabled = false; 
            btn_spin.Enabled = true;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
            //codind for image//
             Assembly myAssembly = Assembly.GetExecutingAssembly();
             Stream mystream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.load.gif");
             Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(Russian_roulette.properties.Resources.load);
           pictureBox.Image = bmp;
                // Image.FromFile(Russian_roulette.Resources.load);
            

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

            //coding for spin sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.loads);
            snd.Play();
            //coding for spin image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.sping.gif");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(Russian_roulette.properties.Resources.sping);
            pictureBox.Image = bmp;
            // Image.FromFile(Russian_roulette.Resources.sping);

        }
        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            //Calling Shoot function from Game Class
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            //coding for shoot sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.shhots);
            snd.Play();
            //coding for spin image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.shoot.gif");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(Russian_roulette.properties.Resources.shoot);
            pictureBox.Image = bmp;
            // Image.FromFile(Russian_roulette.Resources.shoot);

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

        private void Btn_playagain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
        }
    }

    internal class properties
    {
        internal static object resources;
    }
}

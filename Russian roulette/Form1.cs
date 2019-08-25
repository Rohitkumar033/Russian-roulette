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
        int fire = 0, sound = 0, chance = 0,win=0,shoot=0,Count_Shoot=0;
        Bullet instace_Bullet = new Bullet();

        public Form1()
        {
            InitializeComponent();
            sound = instace_Bullet.generateFire();

        }
        public void test() { }
        private void Btn_load_Click(object sender, EventArgs e)
        {
            //coding for sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.loads);
            snd.Play();
            //here is the code to visible the image 
            pbImage.ImageLocation = "empty.jpg";
            // end of the code of the iamge
            //blow coding for load button//
            btn_load.Enabled = false; 
            btn_spin.Enabled = true;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
            //codind for image//
            //this code is used to generate the image at the loading time of the spiiner and load the image to fire 
             Assembly myAssembly = Assembly.GetExecutingAssembly();
             Stream mystream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.load.gif");
             Bitmap bmp = new Bitmap(mystream);

           

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
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.spin);
            snd.Play();
            //coding for spin image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.sping.gif");
            Bitmap bmp = new Bitmap(mystream);

            //this code is used to load the image of the second image of thge game like spinner image of the game 
            pbImage.ImageLocation = "loaded.jpg";

            //var bmp = new Bitmap(Russian_roulette.properties.Resources.sping);
            pictureBox.Image = bmp;
            // Image.FromFile(Russian_roulette.Resources.sping);
            
        }
        private void Btn_shoot_Click(object sender, EventArgs e)
        {

            //Calling Shoot function from Game class
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            shoot = shoot + 1;
            if (shoot== sound)
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.shootsd);
                snd.Play();
               
                shoot = 0;
                sound = instace_Bullet.generateFire();
                Count_Shoot = Count_Shoot+1;
                if (Count_Shoot==1) {
                    MessageBox.Show("Now this is your 2nd chance to fire again ");
                }
                if (Count_Shoot==2) {
                    MessageBox.Show("Your Both chances are over");
                    btn_shoot.Enabled = false;
                }
            }
            if(shoot==6 || shoot==12) {
                MessageBox.Show("Your chances are over try again");
            }

           
        }

        private void PbImage_Click(object sender, EventArgs e)
        {

        }

        private void Btn_shootaway_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            fire++;
            if (fire == sound)
            {
                //Calling Shoot Away function from Game Class
                //coding for shoot away  sound//
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.shootsd);
                snd.Play();
                MessageBox.Show("you are the winner of the game");
                chance++;
                //this code is used to find the winner 
                if (fire == instace_Bullet.winner())
                {
                    win++;
                    MessageBox.Show("You are the Winner of the game");
                    btn_shootaway.Enabled = false;

                }
            }
            //this code is used to count the fire of the bullet from the counter when the counter equal to 6  then generate the ander no of trigger to fire and reset the fire 
            if (fire==6 && chance==1) {
                fire = instace_Bullet.reset();
                sound = instace_Bullet.generateFire();
      
                MessageBox.Show("Now this is your last chance to Fire Again ");
                
            }
            //after two clicking the player not win the game and then the looser message will be display 
            if (chance==2 && win==0) {
                MessageBox.Show("you loose the Game ");
                btn_shootaway.Enabled = false;
            }

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
            fire = 0;
            win = 0;
            chance = 0;
            shoot = 0;
            Count_Shoot = 0;
            
            sound = instace_Bullet.generateFire();

        }
    }
    internal class properties
    {
        internal static object resources;
    }
}

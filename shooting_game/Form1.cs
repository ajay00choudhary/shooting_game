using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace shooting_game
{
    public partial class Game_Interface : Form
    {
        //object of the class
        gun_shoot f = new gun_shoot();
      
        public Game_Interface()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //increment the value of count
            f.count++;
            //checking the value of count
            if (f.count > 2)
            {
                MessageBox.Show("You Lost the Game");
                //decrement the value of the scores
                f.scores = f.scores - 5;
                //showing the scores
                MessageBox.Show("You scores are " + f.scores);
                //setting the properties values
                firebutton.Enabled = false;
                loadbullet.Enabled = false;
                spinchamber.Enabled = false;
            }
            else
            {
                 
                //returning the value
                f.fire1 = f.fire();
                //setting sound file
                SoundPlayer ff = new SoundPlayer(shooting_game.Properties.Resources.fire);
                //playing the sound
                ff.Play();
                //checking the condition for hit or mis
                if (f.compare(f.b_position, f.fire1))
                {
                    if (pointathead.Checked == true)
                    {
                        label2.Text = "Hit " + pointathead.Text;
                    }
                    else
                    {
                        label2.Text = "Hit " + pointatstomach.Text;
                    }
                    f.scores = f.scores + 10;
                    //output the scores
                    MessageBox.Show("You scores are " + f.scores);
                }
                else
                {
                    f.scores = f.scores - 5;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //showing orloading the background image
          
            manpicturebox.BackgroundImage = shooting_game.Properties.Resources.sec;
            f.b_position = f.random_bullet_position();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //setting the click property
            f.b_position = f.random_bullet_position();
            firebutton.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //setting the count value
            f.count = 1;
            loadbullet.Enabled = true;
            spinchamber.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loading the image 
           
            gunpicturebox.Image = shooting_game.Properties.Resources.gun;
        }
    }
}

using Slot_Machine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class GlitterKitty : Form
    {
        public GlitterKitty()
        {
            InitializeComponent();
        }
        int points = 200, spins = 0;
        const int pointsToPlay = 10, tier1 = 200, tier2 = 150, tier3 = 100, tier4 = 70, tier5 = 50;

        Image[] reelPics = { Resources._1blacktiara, Resources._1fattiara, Resources._1sparkletiara, Resources._2grumpycat, Resources._2grumpycat2, 
                               Resources._2grumpycatpillow, Resources._3breadcat, Resources._3pizzacat, Resources._3tortillacat, Resources._4angrytiara, 
                               Resources._4cutetiara, Resources._4greytiara,Resources._4unhappytiara, Resources._4whitetiara, Resources._4whitetiara2,
                               Resources._5bigeyes, Resources._5blackcat, Resources._5happycat, Resources._5jeanscat, Resources._5snowcat, Resources._5tinycat,
                               Resources._5tonguecat};
        Random reelRnd = new Random();

        //Executes when the user Presses Play
        //Subtracts points from user, upps the spin counter, and calls Spin() and Compare() methods
        private void btnPlay_Click(object sender, EventArgs e)
        {
            points -= pointsToPlay;
            lblPoints.Text = String.Format("Points: {0}", points);
            spins++;

            Spin();
            Compare();
        }

        //Executes after Spin the compare the selected images and determine winnings 
        //based on tier system of photos
        private void Compare()
        {
            if ((reel1.Image == reelPics[15] || reel1.Image == reelPics[16] || reel1.Image == reelPics[17] || reel1.Image == reelPics[18] || reel1.Image == reelPics[19] || reel1.Image == reelPics[20] || reel1.Image == reelPics[21]) && (reel2.Image == reelPics[15] || reel2.Image == reelPics[16] || reel2.Image == reelPics[17] || reel2.Image == reelPics[18] || reel2.Image == reelPics[19] || reel2.Image == reelPics[20] || reel2.Image == reelPics[21]) && (reel3.Image == reelPics[15] || reel3.Image == reelPics[16] || reel3.Image == reelPics[17] || reel3.Image == reelPics[18] || reel3.Image == reelPics[19] || reel3.Image == reelPics[20] || reel3.Image == reelPics[21])) 
            {
                points += tier5;
                lblPoints.Text = String.Format("Points: {0}", points);
                lblResult.Text = String.Format("You Won the Tier Five Prize! \n+{0} Points", tier5);
                if (points < 10)
                    btnPlay.Enabled = false;
            }
            else if ((reel1.Image == reelPics[9] || reel1.Image == reelPics[10] || reel1.Image == reelPics[11] || reel1.Image == reelPics[12] || reel1.Image == reelPics[13] || reel1.Image == reelPics[14]) && (reel2.Image == reelPics[9] || reel2.Image == reelPics[10] || reel2.Image == reelPics[11] || reel2.Image == reelPics[12] || reel2.Image == reelPics[13] || reel2.Image == reelPics[14]) && (reel3.Image == reelPics[9] || reel3.Image == reelPics[10] || reel3.Image == reelPics[11] || reel3.Image == reelPics[12] || reel3.Image == reelPics[13] || reel3.Image == reelPics[14])) 
            {
                points += tier4;
                lblPoints.Text = String.Format("Points: {0}", points);
                lblResult.Text = String.Format("You Won the Tier Four Prize! \n+{0} Points", tier4);
                if (points < 10)
                    btnPlay.Enabled = false;
            }
            else if ((reel1.Image == reelPics[6] || reel1.Image == reelPics[7] || reel1.Image == reelPics[8]) && (reel2.Image == reelPics[6] || reel2.Image == reelPics[7] || reel2.Image == reelPics[8]) && (reel3.Image == reelPics[6] || reel3.Image == reelPics[7] || reel3.Image == reelPics[8])) 
            {
                points += tier3;
                lblPoints.Text = String.Format("Points: {0}", points);
                lblResult.Text = String.Format("You Won the Tier Three Prize! \n+{0} Points", tier3);
                if (points < 10)
                    btnPlay.Enabled = false;
            }
            else if ((reel1.Image == reelPics[3] || reel1.Image == reelPics[4] || reel1.Image == reelPics[5]) && (reel2.Image == reelPics[3] || reel2.Image == reelPics[4] || reel2.Image == reelPics[5]) && (reel3.Image == reelPics[3] || reel3.Image == reelPics[4] || reel3.Image == reelPics[5]))
            {
                points += tier2;
                lblPoints.Text = String.Format("Points: {0}", points);
                lblResult.Text = String.Format("You Won the Tier Two Prize! \n+{0} Points", tier2);
                if (points < 10)
                    btnPlay.Enabled = false;
            }
            else if ((reel1.Image == reelPics[0] || reel1.Image == reelPics[1] || reel1.Image == reelPics[2]) && (reel2.Image == reelPics[0] || reel2.Image == reelPics[1] || reel2.Image == reelPics[2]) && (reel3.Image == reelPics[0] || reel3.Image == reelPics[1] || reel3.Image == reelPics[2])) 
            {
                points += tier1;
                lblPoints.Text = String.Format("Points: {0}", points);
                lblResult.Text = String.Format("You Won the Tier One Prize! \n+{0} Points", tier1);
                if (points < 10)
                    btnPlay.Enabled = false;
            }
            else
            {
                lblResult.Text = "Sorry, You Lost This Round!";
                if (points < 10)
                    btnPlay.Enabled = false;
            }
        }

        //Executes to spin the wheel and select new images for comparison
        //Uses spin count to change chances of winner for a more dynamic experience
        private void Spin()
        {
            if (spins <=5)
            {
                reel1.Image = reelPics[reelRnd.Next(9, reelPics.Length - 1)];
                reel2.Image = reelPics[reelRnd.Next(9, reelPics.Length - 1)];
                reel3.Image = reelPics[reelRnd.Next(9, reelPics.Length - 1)];
            }
            else if(spins <= 10)
            {
                reel1.Image = reelPics[reelRnd.Next(0, reelPics.Length - 1)];
                reel2.Image = reelPics[reelRnd.Next(0, reelPics.Length - 1)];
                reel3.Image = reelPics[reelRnd.Next(0, reelPics.Length - 1)];
            }
            else if(spins <= 15)
            {
                reel1.Image = reelPics[reelRnd.Next(4, reelPics.Length - 1)];
                reel2.Image = reelPics[reelRnd.Next(4, reelPics.Length - 1)];
                reel3.Image = reelPics[reelRnd.Next(4, reelPics.Length - 1)];                
            }
            else
            {
                reel1.Image = reelPics[reelRnd.Next(6, reelPics.Length - 1)];
                reel2.Image = reelPics[reelRnd.Next(6, reelPics.Length - 1)];
                reel3.Image = reelPics[reelRnd.Next(6, reelPics.Length - 1)];
                spins = 0;
            }
        }
    }
}

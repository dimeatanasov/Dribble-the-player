using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    public partial class Form1 : Form
    {
        int ballSpeed = 8;
        int ballGravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            ball.Top += ballGravity;
            playerBottom.Left -= ballSpeed;
            playerTop.Left -= ballSpeed;
            scoreLabel.Text = "Score: " + score;

            if (playerBottom.Left < -150)
            {
                playerBottom.Left = 800;
                score++;
            }
            if (playerTop.Left < -180)
            {
                playerTop.Left = 950;
                score++;
            }

            if (ball.Bounds.IntersectsWith(playerTop.Bounds) || ball.Bounds.IntersectsWith(playerBottom.Bounds) ||
                ball.Bounds.IntersectsWith(lineBottom.Bounds) || ball.Bounds.IntersectsWith(lineTop.Bounds))
            {
                endGame();
            }

            if(score > 5)
            {
                ballSpeed = 15;   
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                ballGravity = -15;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                ballGravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreLabel.Text += " Game Over!";
        }
    }
}

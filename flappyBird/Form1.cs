using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }
        // Timer: control the interval of time of events.
        private void gameTimerEvent(object sender, EventArgs e)
        {
            gameOver.Hide();
            Random rand = new Random();
            bird.Top += gravity;
            botPipe.Left -= pipeSpeed;
            topPipe.Left -= pipeSpeed;
            Score.Text = score.ToString();

            if (botPipe.Left < -100)
            {
                botPipe.Left = rand.Next(600,800);
                score++;
            }

            if (topPipe.Left < -100)
            {
                topPipe.Left = rand.Next(500,700);
                score++;
            }

            if (bird.Top< -20)
            {
                EndGame();
                
            }

            if (bird.Bounds.IntersectsWith(botPipe.Bounds) || bird.Bounds.IntersectsWith(topPipe.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
                
            }

        }
        // KeyDown Event : This event raised as soon as the user presses a key on the keyboard, it repeats while the user keeps the key depressed.
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
        // KeyUp Event : This event is raised after the user releases a key on the keyboard.
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = 5;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOver.Show();
        }
    }
}

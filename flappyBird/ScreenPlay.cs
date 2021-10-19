using System;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class ScreenPlay : Form
    {
        protected int score = 0;
        public int PipeSpeed
        {
            get; set;
        }

        public int Gravity
        {
            get; set;
        }


        protected ScreenPlay(int pipeSpeed, int gravity)
        {
            InitializeComponent();

            PipeSpeed = pipeSpeed;
            Gravity = gravity;
        }
        // Timer: control the interval of time of events.
        protected virtual void gameTimerEvent(object sender, EventArgs e)
        {
            gameOver.Hide();

            handleGameOver();
        }
        protected void handleGameOver()
        {
            if (bird.Top < -20 ||
                bird.Bounds.IntersectsWith(botPipe.Bounds) ||
                bird.Bounds.IntersectsWith(topPipe.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();

            }
        }
        // KeyDown Event : This event raised as soon as the user presses a key on the keyboard, it repeats while the user keeps the key depressed.
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -17;
            }
        }
        // KeyUp Event : This event is raised after the user releases a key on the keyboard.
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 13;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOver.Show();
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
    }

}

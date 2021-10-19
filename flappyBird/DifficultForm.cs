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
    public partial class DifficultForm : ScreenPlay, IDifficult
    {
        public DifficultForm(int pipeSpeed, int gravity) : base(pipeSpeed, gravity) {}
        protected override void gameTimerEvent(object sender, EventArgs e)
        {
            gameOver.Hide();

            Random rand = new Random();
            bird.Top += Gravity;
            botPipe.Left -= PipeSpeed;
            topPipe.Left -= PipeSpeed;
            Score.Text = score.ToString();

            if (botPipe.Left < -80)
            {
                botPipe.Left = rand.Next(1900, 2000);
                score++;
                PipeSpeed = increaseSpeedOfBird(PipeSpeed);
            }

            if (topPipe.Left < -80)
            {
                topPipe.Left = rand.Next(1400, 1500);
                score++;
                PipeSpeed = increaseSpeedOfBird(PipeSpeed);
                topPipe.Size = increaseHeightOfPipe(topPipe.Size);
            }

            handleGameOver();
        }
        public int increaseSpeedOfBird(int speed)
        {
            return speed += 4;
        }

        public Size increaseHeightOfPipe(Size size)
        {
            Random rand = new Random();
            size.Height += rand.Next(-50, 50);
            size.Width = 100;
            return size;
        }

        private void DifficultForm_Load(object sender, EventArgs e)
        {

        }

        private void DifficultForm_Load_1(object sender, EventArgs e)
        {

        }
    }

























    public class difficultForm : ScreenPlay, IDifficult
    {
        public difficultForm(int pipeSpeed, int gravity) : base(pipeSpeed, gravity)
        {

        }
        protected override void gameTimerEvent(object sender, EventArgs e)
        {
            gameOver.Hide();

            Random rand = new Random();
            bird.Top += Gravity;
            botPipe.Left -= PipeSpeed;
            topPipe.Left -= PipeSpeed;
            Score.Text = score.ToString();

            if (botPipe.Left < -80)
            {
                botPipe.Left = rand.Next(1900, 2000);
                score++;
                PipeSpeed = increaseSpeedOfBird(PipeSpeed);
            }

            if (topPipe.Left < -80)
            {
                topPipe.Left = rand.Next(1400, 1500);
                score++;
                PipeSpeed = increaseSpeedOfBird(PipeSpeed);
                topPipe.Size = increaseHeightOfPipe(topPipe.Size);
            }

            handleGameOver();
        }
        public int increaseSpeedOfBird(int speed)
        {
            return speed += 4;
        }

        public Size increaseHeightOfPipe(Size size)
        {
            Random rand = new Random();
            size.Height += rand.Next(-50, 50);
            size.Width = 100;
            return size;
        }

       
       
    }
}

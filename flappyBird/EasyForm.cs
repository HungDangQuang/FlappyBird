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
    public partial class EasyForm : ScreenPlay, IDifficult
    {
        public EasyForm(int pipeSpeed, int gravity) : base(pipeSpeed, gravity) {}
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
                topPipe.Left = rand.Next(1300, 1400);
                score++;
                PipeSpeed = increaseSpeedOfBird(PipeSpeed);

            }

            handleGameOver();
        }

        public Size increaseHeightOfPipe(Size size)
        {
            throw new NotImplementedException();
        }

        public int increaseSpeedOfBird( int speed)
        {
            return speed += 1;
        }

        private void EasyForm_Load(object sender, EventArgs e)
        {

        }
    }


















    public class easyForm: ScreenPlay, IDifficult
    {
        public easyForm(int pipeSpeed, int gravity) : base(pipeSpeed, gravity)
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
                topPipe.Left = rand.Next(1500, 1600);
                score++;
                PipeSpeed = increaseSpeedOfBird(PipeSpeed);

            }

            handleGameOver();
        }

        public Size increaseHeightOfPipe(Size size)
        {
            throw new NotImplementedException();
        }

        public int increaseSpeedOfBird(int speed)
        {
            return speed += 1;
        }

        private void EasyForm_Load(object sender, EventArgs e)
        {

        }
    }
}

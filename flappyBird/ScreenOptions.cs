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
    public partial class ScreenOptions : Form
    {
        public ScreenOptions()
        {
            InitializeComponent();
        }

        private void ScreenOptions_Load(object sender, EventArgs e)
        {

        }

        private void Easy_Click(object sender, EventArgs e)
        {       
            EasyForm formEasy = new EasyForm(8, 4);
            formEasy.Show();
            
        }

        private void Difficult_Click(object sender, EventArgs e)
        {
            DifficultForm formDifficult = new DifficultForm(13, 8);
            formDifficult.Show();
        }

    }














    public class screenOption:Form
    {
        private void ScreenOptions_Load(object sender, EventArgs e)
        {

        }

        private void botPipe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void Easy_Click(object sender, EventArgs e)
        {
            EasyForm formEasy = new EasyForm(8, 4);
            formEasy.Show();

        }

        private void Difficult_Click(object sender, EventArgs e)
        {
            DifficultForm formDifficult = new DifficultForm(13, 8);
            formDifficult.Show();
        }
    }
}

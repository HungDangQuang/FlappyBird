using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace flappyBird
{
    interface IDifficult
    {
        int increaseSpeedOfBird(int speed);
        Size increaseHeightOfPipe(Size size);

    }

}

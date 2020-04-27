using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrator.Models
{
    public class Forward : Player
    {
        public override string PassBall()
        {
            return "Shoot the ball towards the opponent net";
        }
    }
}

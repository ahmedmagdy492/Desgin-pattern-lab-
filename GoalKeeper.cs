using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrator.Models
{
    public class GoalKeeper : Player
    {
        public override string PassBall()
        {
            return "pass the ball to the middle of the bitch";
        }
    }
}

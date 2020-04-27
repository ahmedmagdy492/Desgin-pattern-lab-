using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrator.Models
{
    public class MidFeilder : PlayerRoleDecorator
    {
        public MidFeilder(Player _player) : base(_player)
        {            
        }

        public override string PassBall()
        {
            return Player.PassBall() + " and make a long pass";
        }
    }
}

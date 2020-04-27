using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrator.Models
{
    public abstract class PlayerRoleDecorator : Player
    {
        protected Player Player;

        public PlayerRoleDecorator(Player _player)
        {
            Player = _player;
        }

        public Player AssignPlayerRole(Player playerRole)
        {
            Player = playerRole;
            return Player;
        }

        public override string PassBall()
        {
            return Player.PassBall();
        }
    }
}

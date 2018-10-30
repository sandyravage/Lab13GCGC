using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    class Player1 : Player
    {
        public override Roshambo generateRoshambo()
        {
            Roshambo = Roshambo.Rock;
            return Roshambo.Rock;
        }

        public static implicit operator Player1(Player2 v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Player1(Player3 v)
        {
            throw new NotImplementedException();
        }
    }
}

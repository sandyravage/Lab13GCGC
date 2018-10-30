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
    }
}

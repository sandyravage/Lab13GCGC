using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    class Player3 : Player
    {
        public Roshambo generateRoshambo(Roshambo rosh)
        {
            if(rosh == Roshambo.Rock)
            {
                return Roshambo.Paper;
            }
            else if(rosh == Roshambo.Paper)
            {
                return Roshambo.Scissors;
            }
            else
            {
                return Roshambo.Rock;
            }
        }
    }
}

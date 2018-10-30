using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    abstract class Player
    {
        public static Random random = new Random();
        protected string Name { get; set; }
        protected Roshambo Roshambo { get; set; }

        public virtual Roshambo generateRoshambo()
        {
            Roshambo x = (Roshambo)random.Next(1, 4);
            Roshambo = x;
            return x;
        }
    }
}

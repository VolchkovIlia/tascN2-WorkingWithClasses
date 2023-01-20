using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tascN2_Classes
{
    internal class Human
    {
        private int steps1;
        private int steps2;
        private int steps3;

        public int Steps1 { get => steps1; set => steps1 = value; }
        public int Steps2 { get => steps2; set => steps2 = value; }
        public int Steps3 { get => steps3; set => steps3 = value; }

        public  Human(int steps1, int steps2, int steps3)
        {
            Steps1 = steps1;
            Steps2 = steps2;
            Steps3 = steps3;

        }

        public override string ToString()
        {
            return "Участники прошли за день: ( 1 - " + Steps1 + " шагов, 2 - " + Steps2 + "шагов , 3 - " + Steps3 + "шагов )";
        }
    }
}

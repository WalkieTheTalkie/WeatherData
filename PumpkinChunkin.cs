using System;
using System.Collections.Generic;
using System.Text;

namespace WackyWarrior
{
    class PumpkinChunkin : Contestant
    {
        public int distance;
        public PumpkinChunkin(string Name, char Gender, int Age, int distance)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            this.distance = distance;

        }

        public override int calcScore()
        {
            return distance;
        }
    }
}


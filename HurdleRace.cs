using System;
using System.Collections.Generic;
using System.Text;

namespace WackyWarrior
{
    class HurdleRace : Contestant
    {
        public int time;
        public int knockedOver;
        public HurdleRace(string Name, char Gender, int Age, int time, int knockedOver)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            this.time = time;
            this.knockedOver = knockedOver;
        }

        public override int calcScore()
        {
            return 100 - time + knockedOver;
        }

    }
}

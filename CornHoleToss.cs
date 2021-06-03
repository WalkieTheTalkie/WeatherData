using System;
using System.Collections.Generic;
using System.Text;

namespace WackyWarrior
{
    class CornHoleToss : Contestant
    {
        public int nClose;
        public int nlnHole;
        public CornHoleToss(string Name, char Gender, int Age, int nClose, int nlnHole)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            this.nClose = nClose;
            this.nlnHole = nlnHole;

        }

        public override int calcScore()
        {
            return 5 * (nClose + 2 * nlnHole);
        }
    }
}

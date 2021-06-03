using System;
using System.Collections.Generic;
using System.Text;

namespace WackyWarrior
{
  
        abstract class Contestant
        {
            public string Name;
            public char Gender;
            public int Age;

            public abstract int calcScore();
        }
    }


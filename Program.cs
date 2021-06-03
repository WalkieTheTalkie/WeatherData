using System;
using System.Collections.Generic;
using System.Linq;

namespace WackyWarrior
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contestant> hurdle = gethurdleContestant();
            Console.WriteLine("-----");
            List<Contestant> Pumpkin = getPumpkinContestant();
            Console.WriteLine("-----");
            List<Contestant> CornHole = getCornHoleContestant();
            Console.WriteLine("-----");

            Console.WriteLine("-----Pumpkin Result");
            showResult(Pumpkin);
            var pumpkinWinner = Pumpkin.Aggregate((c1, c2) => c1.calcScore() > c2.calcScore() ? c1 : c2);
            Console.WriteLine("----------And the winner is.........." + pumpkinWinner.Name + " Score:" + pumpkinWinner.calcScore() + "Pts");

            Console.WriteLine("-----Corn Hole Result");
            showResult(CornHole);
            var cornHoleWinner = CornHole.Aggregate((c1, c2) => c1.calcScore() > c2.calcScore() ? c1 : c2);
            Console.WriteLine("----------And the winner is.........." + cornHoleWinner.Name + " Score:" + cornHoleWinner.calcScore() + "Pts");

            Console.WriteLine("-----Hurdle Result");
            showResult(hurdle);
            var hurdleWinner = hurdle.Aggregate((c1, c2) => c1.calcScore() > c2.calcScore() ? c1 : c2);
            Console.WriteLine("----------And the winner is.........." + hurdleWinner.Name + " Score:" + hurdleWinner.calcScore() + "Pts");

            Console.ReadKey();
        }
        public static List<Contestant> gethurdleContestant()
        {
            Console.WriteLine("Enter hurdle contestant details");
            List<Contestant> hurdleContestantList = new List<Contestant>();
            for (; ; )//infinite loop
            {
                Console.Write("Name:");
                String name = Console.ReadLine().ToString();
                Console.Write("Gender:");
                char gender = Char.Parse(Console.ReadLine());
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine().ToString());

                Console.Write("Time:");
                int time = int.Parse(Console.ReadLine().ToString());
                Console.Write("knocked Over:");
                int knockedOver = int.Parse(Console.ReadLine().ToString());
                HurdleRace hurdleContestant = new HurdleRace(name, gender, age, time, knockedOver);
                hurdleContestantList.Add(hurdleContestant);
                Console.Write("Add new hurdle contestant?(y/n)");
                if (Char.Parse(Console.ReadLine()) == 'y')
                {
                    continue;
                }
                break;
            }
            return hurdleContestantList;
        }
        public static List<Contestant> getPumpkinContestant()
        {
            Console.WriteLine("Enter Pumpkintn contestant details");
            List<Contestant> PumpkintnContestantList = new List<Contestant>();
            for (; ; )//infinite loop
            {
                Console.Write("Name:");
                String name = Console.ReadLine().ToString();
                Console.Write("Gender:");
                char gender = Char.Parse(Console.ReadLine());
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine().ToString());

                Console.Write("Distance:");
                int distance = int.Parse(Console.ReadLine().ToString());

                PumpkinChunkin pumpkinContestant = new PumpkinChunkin(name, gender, age, distance);
                PumpkintnContestantList.Add(pumpkinContestant);
                Console.Write("Add new Pumpkintn contestant?(y/n)");
                if (Char.Parse(Console.ReadLine()) == 'y')
                {
                    continue;
                }
                break;
            }
            return PumpkintnContestantList;
        }
        public static List<Contestant> getCornHoleContestant()
        {
            Console.WriteLine("Enter CornHole contestant details");
            List<Contestant> CornHoleContestantList = new List<Contestant>();
            for (; ; )//infinite loop
            {
                Console.Write("Name:");
                String name = Console.ReadLine().ToString();
                Console.Write("Gender:");
                char gender = Char.Parse(Console.ReadLine());
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine().ToString());

                Console.Write("Number within 1 feet:");
                int nClose = int.Parse(Console.ReadLine().ToString());
                Console.Write("Number in hole:");
                int nlnHole = int.Parse(Console.ReadLine().ToString());

                CornHoleToss CornHoleContestant = new CornHoleToss(name, gender, age, nClose, nlnHole);
                CornHoleContestantList.Add(CornHoleContestant);
                Console.Write("Add new CornHole contestant?(y/n)");
                if (Char.Parse(Console.ReadLine()) == 'y')
                {
                    continue;
                }
                break;
            }
            return CornHoleContestantList;
        }

        public static void showResult(List<Contestant> list)
        {
            foreach (var c in list)
            {
                Console.WriteLine("Contestant:" + c.Name + " Age:" + c.Age + "Pts:" + c.calcScore());
            }

        }
    }
}


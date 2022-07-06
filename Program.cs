// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-exquisite-corpse
using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Q21 is final work here

            Console.WriteLine("Welcome to the Exquisite Corpse Game!\n");

            Console.WriteLine("So what do you want to do build your creature or have a random creature made for you? Type 1 to build and 2 for random");

            Console.Write("Type 1 or 2: ");

            string choice1 = Console.ReadLine();

            if (choice1 == "1")
            {
                Console.WriteLine("We have three creatures for you!\n");
                Console.WriteLine("For the head what creature are you going to use?");
                Console.Write("ghost, monster, or bug: ");
                string headChoice = Console.ReadLine();

                Console.WriteLine("For the body what creature are you going to use?");
                Console.Write("ghost, monster, or bug: ");
                string bodyChoice = Console.ReadLine();

                Console.WriteLine("For the feet what creature are you going to use?");
                Console.Write("ghost, monster, or bug: ");
                string feetChoice = Console.ReadLine();

                BuildACreature(headChoice, bodyChoice, feetChoice);
            }
            else if (choice1 == "2")
            {
                RandomMode();
            }
            else
            {
                Console.WriteLine("INVALID!");
            }

        }

        static void BuildACreature(string head = "ghost", string body = "monster", string feet = "bug") // Q2 - Q3
        {
            // Q17 tells us to delete the entire method make it empty

            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);

        }

        static void RandomMode()
        {
            // Q8- Q9
            Random randomNumber = new Random();

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            // Q13
            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            // Q10
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }

        }

        static int TranslateToNumber(string creature)
        {
            // Q15 - Q16
            creature = creature.ToLower();
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}

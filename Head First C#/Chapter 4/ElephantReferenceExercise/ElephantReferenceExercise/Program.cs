using System;

namespace ElephantReferenceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

            while (true)
            {
                char choice = Console.ReadKey(true).KeyChar;

                Console.WriteLine("You pressed " + choice);

                if (choice == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");

                    lloyd.WhoAmI();
                }
                else if (choice == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");

                    lucinda.WhoAmI();
                }
                else if (choice == '3')
                {
                    Console.WriteLine("References have been swapped");

                    Elephant temp = lloyd;

                    lloyd = lucinda;
                    lucinda = temp;
                }
                else if (choice == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (choice == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else
                {
                    return;
                }

                Console.WriteLine();
            }
        }
    }
}

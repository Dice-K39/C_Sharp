using System;

namespace Paintball
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "Number of balls");
            int magazineSize = ReadInt(16, "Magazine size");

            Console.Write($"Loaded [false]: ");

            bool.TryParse(Console.ReadLine(), out bool isLoaded);

            PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);

            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");

                if (gun.IsEmpty())
                {
                    Console.WriteLine("WARNING: You're out of ammo");
                }

                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");

                char key = Console.ReadKey(true).KeyChar;

                if (key == ' ')
                {
                    Console.WriteLine($"Shooting returned {gun.Shoot()}");
                }
                else if (key == 'r')
                {
                    gun.Reload();
                }
                else if (key == '+')
                {
                    gun.Balls += gun.MagazineSize;
                }
                else if (key == 'q')
                {
                    return;
                }
            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            // Write the prompt followed by [default value]:
            Console.Write(prompt + " [" + lastUsedValue + "]: ");

            // Read the line from the input and use int.TryParse to attempt to parse it
            string stringValue = Console.ReadLine();

            if (int.TryParse(stringValue, out int value))
            {
                // If it can be parsed, write " using value" + value to the console
                Console.WriteLine(" using value " + value);

                return value;
            }
            else
            {
                // Otherwise write " using default value" + lastUsedValue to the console
                Console.WriteLine(" using default value " + lastUsedValue);

                return lastUsedValue;
            }
        }

    }
}

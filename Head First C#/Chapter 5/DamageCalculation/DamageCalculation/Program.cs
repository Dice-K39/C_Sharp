using System;

namespace DamageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage damage = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                damage.Roll = 0;
                damage.Damage = 0;

                Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");

                char choice = Console.ReadKey().KeyChar;

                if (choice != '0' && choice != '1' && choice != '2' && choice != '3')
                {
                    return;
                }

                for (int i = 0; i < 3; i++)
                {
                    damage.Roll += random.Next(1, 7);
                }

                damage.SetMagic(choice == '1' || choice == '3');
                damage.SetFlaming(choice == '2' || choice == '3');

                Console.WriteLine("Rolled " + damage.Roll + " for " + damage.Damage + " HP\n");
            }
        }
    }
}

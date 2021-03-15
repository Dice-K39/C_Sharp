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

                for (int i = 0; i < 3; i++)
                {
                    damage.Roll += random.Next(1, 7);
                }

                switch (choice)
                {
                    case '0':
                        {
                            damage.SetMagic(false);
                            damage.SetFlaming(false);
                            break;
                        }
                    case '1':
                        {   
                            damage.SetMagic(true);
                            damage.SetFlaming(false);
                            break;
                        }
                    case '2':
                        {
                            damage.SetMagic(false);
                            damage.SetFlaming(true);
                            break;
                        }
                    case '3':
                        {
                            damage.SetMagic(true);
                            damage.SetFlaming(true);
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }

                Console.WriteLine("Rolled " + damage.Roll + " for " + damage.Damage + " HP\n");
            }
        }
    }
}

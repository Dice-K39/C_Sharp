using System;
namespace PickRandomCards
{
    public class CardPicker
    {
        static Random random = new Random();
        
        public CardPicker()
        {
        }

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            Random random2 = new Random();
            double[] randomDoubles = new double[20];

            for (int i = 0; i < randomDoubles.Length; i++)
            {
                double value = random2.NextDouble();

                randomDoubles[i] = value;
                Console.WriteLine(randomDoubles[i]);
            }

            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "Ace";

            if (value == 11) return "Jack";

            if (value == 12) return "Queen";

            if (value == 13) return "King";

            return value.ToString();
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            if (value == 1) return "Spades";

            if (value == 2) return "Hearts";

            if (value == 3) return "Clubs";

            return "Diamonds";
        }
    }
}

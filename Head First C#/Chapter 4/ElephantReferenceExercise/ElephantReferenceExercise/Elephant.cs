using System;
namespace ElephantReferenceExercise
{
    public class Elephant
    {
        public string Name;
        public int EarSize;

        public Elephant()
        {
        }

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + '.');
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }
    }
}

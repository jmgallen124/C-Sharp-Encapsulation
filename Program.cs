// Jeremy Gallen's sample program to demonstrate encapsulation

namespace Encapsulation
{
    // Hero class
    public class Hero
    {
        // Private variables
        private string heroName;
        private int heroAge;

        // Accessors for name
        public string Name
        {
            get { return heroName; }
            set { heroName = value; }
        }

        // Accessors for age
        public int Age
        {
            get { return heroAge; }
            set { heroAge = value; }
        }
    }
    internal class Program
    {
        // Main function
        static void Main(string[] args)
        {
            // Create new hero
            Hero Jeremy = new Hero();

            // Set name
            Jeremy.Name = "Jeremy";

            // Set age
            Jeremy.Age = 38;

            // Display attributes
            Console.WriteLine("Hero Name: " + Jeremy.Name);
            Console.WriteLine("Hero Age: " + Jeremy.Age);
        }
    }
}
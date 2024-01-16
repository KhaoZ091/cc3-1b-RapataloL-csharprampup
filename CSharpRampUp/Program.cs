namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //converter
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Weight in Pounds (lbs): ");
            int pound = Convert.ToInt32(Console.ReadLine());
            double kilogram = pound / 2.20;
            Console.WriteLine("Weight converted to Kilogram (kg): " + kilogram);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Length in Miles (mi): ");
            int mile = Convert.ToInt32(Console.ReadLine());
            double kilometer = mile * 1.60;
            Console.WriteLine("length in Kilometers:" + kilometer);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Temperature in Fahrenheit:");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 0.555;
            Console.WriteLine("Temperature in Celsius:" + celsius);

            //average 
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Age of Student 1:");
            int Student_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 2:");
            int Student_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 3:");
            int Student_Three = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 4:");
            int Student_Four = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 5:");
            int Student_Five = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 6:");
            int Student_Six = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 7:");
            int Student_Seven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 8:");
            int Student_Eight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 9:");
            int Student_Nine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 10:");
            int Student_Ten = Convert.ToInt32(Console.ReadLine());

            double Average_age = (Student_One + Student_Two + Student_Three + Student_Four + Student_Five + Student_Six + Student_Seven + Student_Eight + Student_Nine + Student_Ten) / 10;
            Console.WriteLine("The Average age is: " + Average_age);

            //Storymaking
            {
                string name, character_class, weapon, weapon_name, weapon_ability, special_ability;

                do
                {
                    Console.WriteLine("Create a name for your character: ");
                    name = Console.ReadLine();
                } while (string.IsNullOrEmpty(name));

                do
                {
                    Console.WriteLine("What is the class of this character (e.g., knight): ");
                    character_class = Console.ReadLine();
                } while (string.IsNullOrEmpty(character_class));

                do
                {
                    Console.WriteLine("What type of weapon are you using?: ");
                    weapon = Console.ReadLine();
                } while (string.IsNullOrEmpty(weapon));

                do
                {
                    Console.WriteLine("What would be the name of your weapon?: ");
                    weapon_name = Console.ReadLine();
                } while (string.IsNullOrEmpty(weapon_name));

                do
                {
                    Console.WriteLine("Create a name for your weapon's ability: ");
                    weapon_ability = Console.ReadLine();
                } while (string.IsNullOrEmpty(weapon_ability));

                do
                {
                    Console.WriteLine("What would be the name of your special ability?: ");
                    special_ability = Console.ReadLine();
                } while (string.IsNullOrEmpty(special_ability));

                Console.WriteLine($"In a place called Steinberg was a {character_class} named {name}.");
                Console.ReadKey();
                Console.WriteLine($"{name} was said to have slain the all-powerful Dark Mage, Morgan.");
                Console.ReadKey();
                Console.WriteLine($"{name}'s preferred weapon was {weapon}s in which one of it was named, {weapon_name}.");
                Console.ReadKey();
                Console.WriteLine($"The weapon named {weapon_name} was blessed with the ability {weapon_ability}, which was said to do devastating damage to the dark mage.");
                Console.ReadKey();
                Console.WriteLine($"{name}'s final attack was said to be his special ability, and it was called {special_ability}. This ability caused such destruction that it was seen through the whole land of Sindria.");
                Console.WriteLine($"As {name} slayed the mighty dark mage, the power of Sindria once again flourished as there is no one to take it from them anymore.");
            }

            //this is the rigt triangle pattern
            Console.WriteLine("-----------------------------");
            Console.WriteLine("input: ");
            int max_row = Convert.ToInt32(Console.ReadLine());
            int a = 1;

            for (int row = 1; row <= max_row; row++)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write(a);
                    a++;

                }
                Console.WriteLine();
                a = 1;
            }
            //this is the pattern adder
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = 0;
                for (int i = 1; i <= n; sum += i, Console.Write(i + (i++ < n ? "+" : ""))) ;
                Console.WriteLine($"\nOutput: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            //this is the reverse right triangle pattern
            Console.WriteLine("-----------------------------");
            Console.WriteLine("input: ");
            int max_rows = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            for (int row = 1; row <= max_rows; max_rows--)
            {
                for (int col = 1; col <= max_rows; ++col)
                {
                    Console.Write(b);
                    b++;

                }
                Console.WriteLine();
                b = 1;
            }

        }
    }
}
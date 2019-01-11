using System;

namespace hwOOP2
{
    class Rabbit : IMammal
    {
        enum EyeColor { blue, red, black }

        enum FurColor { white, brown, black, grey }

        enum Gender { male, female }

        public DateTime BirthDate
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

            Rabbit rabbit = new Rabbit();
            Console.WriteLine("Please enter rabbit name:");
            string rabbitName = Console.ReadLine();

            Console.WriteLine("===================================");

            Console.WriteLine("Please select rabbit gender: M or F.");
            string gender = Console.ReadLine();
           
            if (gender == "M")
            {
                gender = Gender.male.ToString();
            }
            else if (gender == "F")
            {
                gender = Gender.female.ToString();
            };

            Console.WriteLine("===================================");

            Console.WriteLine("Please select fur color: white, brown, black, grey");
            string furColor = Console.ReadLine();

            if (furColor == "white")
            {
                furColor = FurColor.white.ToString();
            }
            if (furColor == "brown")
            {
                furColor = FurColor.brown.ToString();
            }
            if (furColor == "black")
            {
                furColor = FurColor.black.ToString();
            }
            else if (furColor == "grey")
            {
                furColor = FurColor.grey.ToString();
            }

            Console.WriteLine("===================================");

            Console.WriteLine("Please select eye color: blue, red, black");
            string eyeColor = Console.ReadLine();

            if (eyeColor == "blue")
            {
                eyeColor = EyeColor.blue.ToString();
            }
            if (eyeColor == "red")
            {
                eyeColor = EyeColor.red.ToString();
            }
           else  if (eyeColor == "black")
            {
                eyeColor = EyeColor.black.ToString();
            }

            Console.WriteLine("===================================");

            Console.WriteLine("How fast does the rabbit move?");
            int speed = Int32.Parse(Console.ReadLine());

            Console.WriteLine("===================================");

            Console.WriteLine("How many hours does the rabbit sleep?");
            int hours = Int32.Parse(Console.ReadLine());

            Console.WriteLine("===================================");

            Console.WriteLine("What does your rabbit like to eat?");
            string food = Console.ReadLine();

            Console.WriteLine("===================================");

            Console.Write("Enter the birth date of the rabbit (as mm/dd/yyyy): ");

            rabbit.BirthDate = DateTime.Parse(Console.ReadLine());

            double rabbitAge = (DateTime.Now - rabbit.BirthDate).TotalDays / 365.2425;

            int rabbitAge1 = Convert.ToInt32(rabbitAge);
            int rabbitAge2 = (int)rabbitAge;

            Console.WriteLine($"{rabbitName} is {rabbitAge2} years old");

            Console.WriteLine("======================================");

            Console.WriteLine($"{rabbitName} is a {gender} rabbit who has {furColor} fur color and {eyeColor} eye color");

            Console.WriteLine("======================================");


            rabbit.Eats(rabbitName, food);
            rabbit.Moves(rabbitName, speed);
            rabbit.Sleeps(rabbitName, hours);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Rabbit gigi = new Rabbit();

            Console.Write("Enter the birth date of the rabbit (as mm/dd/yyyy): ");

            gigi.BirthDate = DateTime.Parse(Console.ReadLine());

            double age = (DateTime.Now - gigi.BirthDate).TotalDays / 365.2425;

            int age1 = Convert.ToInt32(age);
            int age2 = (int)age;

            Console.WriteLine($"Gigi is {age2} years old");

            Console.WriteLine("======================================");

            Console.WriteLine($"Gigi is a {Gender.male} rabbit who has {FurColor.brown} fur color and {EyeColor.blue} eye color");

            Console.WriteLine("======================================");


            gigi.Eats("Gigi", "carrots");
            gigi.Moves("Gigi", 23);
            gigi.Sleeps("Gigi", 2);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

            Rabbit gica = new Rabbit();

            Console.Write("Enter the birth date of the rabbit (as mm/dd/yyyy): ");



            gica.BirthDate = DateTime.Parse(Console.ReadLine());

            double gicaAge = (DateTime.Now - gica.BirthDate).TotalDays / 365.2425;

            int gicaAge1 = Convert.ToInt32(gicaAge);
            int gicaAge2 = (int)gicaAge;

            Console.WriteLine($"Gica is {gicaAge2} years old");

            Console.WriteLine("======================================");

            Console.WriteLine($"Gica is a {Gender.female} rabbit who has {FurColor.grey} fur color and {EyeColor.black} eye color");

            Console.WriteLine("======================================");


            gica.Eats("Gica", "salad");
            gica.Moves("Gica", 15);
            gica.Sleeps("Gica", 8);
        }

        public void Moves(string mammalName, int speed)
        {
            Console.WriteLine($"{mammalName} moves {speed} km/h");
        }

        public void Sleeps(string mammalName, int hours)
        {
            Console.WriteLine($"{mammalName} sleeps {hours} hours at night");
        }

        public void Eats(string mammalName, string food)
        {

            Console.WriteLine($"{mammalName} likes to eat {food}");
        }
    }

}

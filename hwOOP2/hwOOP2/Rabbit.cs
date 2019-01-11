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
            Rabbit rabbit = new Rabbit();

            Console.WriteLine($"Rabbit is {Gender.female}, has {FurColor.grey} fur color and {EyeColor.black} eye color");

            Console.Write("Enter the birth date of the rabbit (as mm/dd/yyyy): ");
            rabbit.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Rabbit is {(DateTime.Now - rabbit.BirthDate).TotalDays / 365.2425} years old");

            rabbit.Eats("carrots");
            rabbit.Moves();
            rabbit.Sleeps();

        }

        public void Moves()
        {
            Console.WriteLine("Rabbit moves fast");
        }

        public void Sleeps()
        {
            Console.WriteLine("Rabbits sleep at night");
        }

        public void Eats(string food)
        {

            Console.WriteLine($"Rabbit eats {food}");
        }
    }

}

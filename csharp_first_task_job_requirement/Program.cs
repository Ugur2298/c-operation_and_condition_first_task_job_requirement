using System;

namespace csharp_first_task_job_requirement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // First variant
            Console.WriteLine("Welcome to our company. Please write information about yourself:");
            Console.WriteLine("Please write your name: ");
            string employeerName = Console.ReadLine();
            Console.WriteLine("Please write your surname: ");
            string employeerSurName = Console.ReadLine();
            Console.WriteLine("Please write your father's name: ");
            string employeerFatherName = Console.ReadLine();
            Console.WriteLine("Please write your genre: ");
            string employeerGenre = Console.ReadLine();
            Console.WriteLine("Please write your birth date: ");
            int employeerBirthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write your address: ");
            string employeerAddress = Console.ReadLine();
            int currentAge = 2024 - employeerBirthDate;

            Console.WriteLine("You: " + employeerName + " " + employeerSurName + " " + employeerFatherName + " " + "was born in " + employeerBirthDate + ". " + " Today your age is " + (currentAge));
            if (currentAge < 10)
            {
                Console.WriteLine("You are a child.We can't choose you");
            }
            else if ((currentAge > 10) && (currentAge < 15))
            {
                Console.WriteLine("You are a teenager.We can't choose you");
            }
            else if ((currentAge > 15) && (currentAge < 30))
            {
                Console.WriteLine("You are a young person.We can choose you");
            }
            else if ((currentAge > 30) && (currentAge < 60))
            {
                Console.WriteLine("You are a maturity person.We can't choose you");
            }
            else
            {
                Console.WriteLine("You are an old person.Your age is more than 60 and we can't choose you.");
            }

            //Second variant

            Console.WriteLine("Welcome to our company. Please write information about yourself:");
            Console.WriteLine("Please write your name: ");
            string employeer2Name = Console.ReadLine();
            Console.WriteLine("Please write your surname: ");
            string employeer2SurName = Console.ReadLine();
            Console.WriteLine("Please write your father's name: ");
            string employeer2FatherName = Console.ReadLine();
            Console.WriteLine("Please write your genre: ");
            string employeer2Genre = Console.ReadLine();
            Console.WriteLine("Please write your birth date: ");
            int employeer2BirthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write your address: ");
            string employeer2Address = Console.ReadLine();
            int currentAge2 = DateTime.Now.Year- employeer2BirthDate;

            Console.WriteLine("You: " + employeer2Name + " " + employeer2SurName + " " + employeer2FatherName + " " + "was born in " + employeer2BirthDate + ". " + " Today your age is " + (currentAge2));


            if (currentAge2 < 10)
            {
                Console.WriteLine("You are a child.We can't choose you");
            }
            else if ((currentAge2 > 10) && (currentAge2 < 15))
            {
                Console.WriteLine("You are a teenager.We can't choose you");
            }
            else if ((currentAge2 > 15) && (currentAge2 < 30))
            {
                Console.WriteLine("You are a young person.We can choose you");
            }
            else if ((currentAge2 > 30) && (currentAge2 < 60))
            {
                Console.WriteLine("You are a maturity person.We can't choose you");
            }
            else
            {
                Console.WriteLine("You are an old person.Your age is more than 60 and we can't choose you.");
            }


            
        }
    }
}

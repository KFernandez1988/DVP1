using System;

namespace DVP1.CE1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name: Kevin Fernandez-Gonzalez
            // Date: 1812
            // Course: Project & Portfolio 1
            // synopsis: This is my DVP1 Project, Here I will save individual projects during my course and make it one



            Console.WriteLine("Coding Challenge Menu: Please enter the number for the challenge you want to run... \r\n" +
                "[1] Swap name \r\n" +
                "[2] Backward \r\n" +
                "[0} exit");

            string choice = Console.ReadLine();
            int intChoice = 0;


            do {
                 
                while (!int.TryParse(choice, out intChoice) &&  (intChoice >= 6 || intChoice < 0) && string.IsNullOrEmpty(choice)) {
                Console.WriteLine("Please enter a number from the option menu \r\n \r\n" +
                    "Coding Challenge Menu: Please enter the number for the challenge you want to run... \r\n" +
                "[1] Swap name \r\n" +
                "[2] Backward \r\n" +
                "[0} exit");
                choice = Console.ReadLine();
                intChoice = int.Parse(choice);
            }
            if (intChoice == 1) {
                // swap name code challenge.
                SwapName swappingNames = new SwapName();

                Console.WriteLine("To Begin please enter your first name..");
                string name = Console.ReadLine();
                name = swappingNames.ValidateName(name);

                Console.WriteLine("Thank you {0}, now I will need your last name", name);
                string lastName = Console.ReadLine();
                lastName = swappingNames.ValidateName(lastName);

                swappingNames.SetSwapName(name, lastName);
            }
            if (intChoice == 2)
            {
                Backwards backwards = new Backwards();
                Console.WriteLine("Welcome to Backwards: To begin, please enter a sentence containing at least 6 words...");

                string sentence = Console.ReadLine();
                while (!backwards.Validation(sentence))
                {
                    Console.WriteLine("Please enter with atleast 6 words ");
                    sentence = Console.ReadLine();
                }
                backwards.SetBackwards(sentence);
            }
            if (intChoice == 0)
            {
                Console.WriteLine("Bye now, Thanks for playing");
            }
                choice = Console.ReadLine();
                intChoice = 0;
            } while (intChoice == 0) ;


        }
    }
}

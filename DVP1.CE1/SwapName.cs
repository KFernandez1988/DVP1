using System;
using System.Collections.Generic;
using System.Text;

namespace DVP1.CE1
{
    class SwapName
    {
        // Name: Kevin Fernandez-Gonzalez
        // Date: 1811
        // Course: Project & Portfolio 1
        // synopsis: This class is build for swapping the first name and the last name

        public SwapName()
        {

        }

        public void SetSwapName(string name, string lastName)
        {
            Console.WriteLine("Excellente! your name ({0} {1}) reverse would be {1}, {0}", name, lastName);

        }

        public string ValidateName(string nameOrLastName)
        {

            while (String.IsNullOrEmpty(nameOrLastName))
            {
                Console.WriteLine("Please enter something");
                nameOrLastName = Console.ReadLine();

            }
            return nameOrLastName;

        }
    }
}

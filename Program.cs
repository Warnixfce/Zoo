using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo z = new Zoo();            
            string option;
            Console.WriteLine("\nWelcome to {0}! \nThis zoo is located in {1} and our operating hours are {2}.\n", z.Name, z.City, z.OpHours);
            Console.WriteLine("Option 1: Animal quantity");
            Console.WriteLine("Option 2: Add an animal to the zoo");
            Console.WriteLine("Option 3: Remove an animal from the zoo");
            Console.WriteLine("Option 4: Descriptions of all animals currently living in the zoo");
            Console.WriteLine("Option 5: Description of an animal currently living in the zoo");
            Console.WriteLine("Option 6: Admission Price");
            Console.WriteLine("Option 0: Log out of the system\n");

            do
            {
                Console.Write("\nPlease enter an option: ");
                option = Console.ReadLine();
                bool menuToValidate = MenuValidation(option);

                if (menuToValidate == false)
                {
                    continue;
                }

                switch (option)
                {
                    
                    case "1":
                        z.QuantityInZoo();                        
                        break;
                    
                    case "2":
                        z.AddAnimal();
                        break;
                    
                    case "3":
                        z.RemoveAnimal();
                        break;
                    
                    case "4":
                        z.AnimalDescriptions();
                        break;

                    case "5":
                        z.PrintDescription();
                        break;

                    case "6":
                        z.AdmissionPrice();
                        break;

                    case "0":
                        Console.WriteLine("\n\nThank you for your visit!\nHope to see you again soon\n\n>Press any key to log out of the system<");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid option. You must enter an option from the menu.\n");
                        break;
                }
            }
            while (option != "0");

        }

        public static bool MenuValidation(string optionMenu)
        {
            bool Flag = true;
            int optionValid;
            int k = 0;
            int m = 6;
                        
            if (!int.TryParse(optionMenu, out optionValid))
            {
                Console.WriteLine("Invalid option. No number entered.\n");
                Flag = false;
            }            
            else if (optionValid < k || optionValid > m)
            {
                Console.WriteLine("Invalid option. You must enter an option from the menu.\n");
                Flag = false;
            }
            return Flag;

        }
    }
}

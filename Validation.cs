using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    static class Validation
    {
        public static bool StringValidation(string characters, string type)
        {
            bool Flag = false;

            if (string.IsNullOrEmpty(characters))
            {
                Console.WriteLine("The {0} mustn't be empty.", type);
            }
            else if (characters.Any(char.IsDigit))
            {
                Console.WriteLine("The {0} mustn't contain numbers.", type);
            }
            else
            {
                Flag = true;
            }
            return Flag;
        }

        public static bool OptionValidation(string option, string type, string char1, string char2)
        {
            bool Flag = false;
            if (string.IsNullOrEmpty(option))
            {
                Console.WriteLine("The {0} mustn't be empty.", type);
            }
            else if (option != char1 && option != char2)
            {
                Console.WriteLine("The {0} must be \'{1}\' or \'{2}\'.", type, char1, char2);
            }
            else
            {
                Flag = true;
            }

            return Flag;
        }

        public static bool ForFloats(string entryFloat, ref float floatNumber)
        {
            bool Flag = false;

            if (!float.TryParse(entryFloat, out float floatNumberValid))
            {
                Console.WriteLine("You must enter a number.");
            }
            else if (floatNumberValid <= 0f)
            {
                Console.WriteLine("You must enter a positive number.");
            }
            else
            {
                floatNumber = floatNumberValid;
                Flag = true;
            }

            return Flag;
        }

        public static bool ForIntegers(string entryInt, ref int intNumber)
        {
            bool Flag = false;

            if (!int.TryParse(entryInt, out int intNumberValid))
            {
                Console.WriteLine("You must enter a number.");
            }
            else if (intNumberValid < 0)
            {
                Console.WriteLine("You must enter zero or a positive number.");
            }
            else
            {
                intNumber = intNumberValid;
                Flag = true;
            }

            return Flag;
        }



    }

   
}

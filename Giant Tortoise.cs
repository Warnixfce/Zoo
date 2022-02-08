using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Giant_Tortoise : Animal
    {
        public float Age { get; set; }

        public void CreatedGiantTortoise(Giant_Tortoise gTor, ref float age)
        {
            float ageValid;
            bool Flag = false;
            do
            {
                Console.WriteLine("Please enter {0}'s age (in years): ", gTor.Name);
                string ageToValidate = Console.ReadLine();

                if (!float.TryParse(ageToValidate, out ageValid))
                {
                    Console.WriteLine("You must enter a number.");                    
                }
                else if (ageValid < 0f)
                {
                    Console.WriteLine("You must enter a positive number.");                    
                }
                else
                {
                    Console.WriteLine("{0}'s age is {1} years old", gTor.Name, ageValid);
                    Flag = true;
                }
            } while (Flag == false);

            age = ageValid;
        }

        public void Youth(Giant_Tortoise gTor)
        {
            if (gTor.Age < 50f)
            {                
                Console.WriteLine("Since {0}'s age is {1} years, {0} is young (under 50 years' old).", gTor.Name, gTor.Age, gTor.Name);
            }
            else if (gTor.Age >= 50f && gTor.Age <= 100f)
            {
                Console.WriteLine("Since {0}'s age is {1} years, {0} is middle-aged (between 50 and 100 years old).", gTor.Name, gTor.Age, gTor.Name);
            }
            else
            {
                Console.WriteLine("Since {0}'s age is {1} years, {0} is old (over 100 years' old).", gTor.Name, gTor.Age, gTor.Name);
            }
        }
    }
}

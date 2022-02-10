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
            bool Flag;
            do
            {
                Console.WriteLine("Please enter {0}'s age (in years): ", gTor.Name);
                string entry = Console.ReadLine();
                Flag = Validation.ForFloats(entry, ref age);
            } while (Flag == false);

            Console.WriteLine("{0}'s age is {1} years old.", gTor.Name, age);                        
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

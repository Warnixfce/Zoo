using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Giraffe : Animal 
    {
        public float Height { get; set; }

        public void CreatedGiraffe(Giraffe gir, ref float heightGiraffe)
        {
            float heightValid;
            bool Flag = false;
            do
            {
                Console.WriteLine("Please enter {0}'s height (in meters): ", gir.Name);
                string height = Console.ReadLine();

                if (!float.TryParse(height, out heightValid))
                {
                    Console.WriteLine("You must enter a number.");                    
                }
                else if (heightValid <= 0f)
                {
                    Console.WriteLine("You must enter a positive number.");                    
                }
                else
                {
                    Console.WriteLine("{0}'s height is {1}m.", gir.Name, heightValid);
                    Flag = true;
                }
            } while (Flag == false);

            heightGiraffe = heightValid;
        }

        public void CompareHeight(Giraffe giraffeToCompare)
        {          
            if(giraffeToCompare.Gender == "M")
            {
                if(giraffeToCompare.Height < 5.5f)
                {
                    Console.WriteLine("Since {0}'s height is {1}m, {2} is shorter than the average giraffe (5.5m).", giraffeToCompare.Name, giraffeToCompare.Height, giraffeToCompare.Name);
                }
                else if(giraffeToCompare.Height == 5.5f)
                {
                    Console.WriteLine("Since {0}'s height is {1}m, {2} has an average height.", giraffeToCompare.Name, giraffeToCompare.Height, giraffeToCompare.Name);
                }
                else
                {
                    Console.WriteLine("Since {0}'s height is {1}m, {2} is taller than the average giraffe (5.5m).", giraffeToCompare.Name, giraffeToCompare.Height, giraffeToCompare.Name);
                }
                
            }
            if (giraffeToCompare.Gender == "F")
            {
                if (giraffeToCompare.Height < 4.6f)
                {
                    Console.WriteLine("Since {0}'s height is {1}m, {2} is shorter than the average giraffe (4.6m).", giraffeToCompare.Name, giraffeToCompare.Height, giraffeToCompare.Name);
                }
                else if (giraffeToCompare.Height == 4.6f)
                {
                    Console.WriteLine("Since {0}'s height is {1}m, {2} has an average height.", giraffeToCompare.Name, giraffeToCompare.Height, giraffeToCompare.Name);
                }
                else
                {
                    Console.WriteLine("Since {0}'s height is {1}m, {2} is taller than the average giraffe (4.6m).", giraffeToCompare.Name, giraffeToCompare.Height, giraffeToCompare.Name);
                }
            }

        }
    }
}

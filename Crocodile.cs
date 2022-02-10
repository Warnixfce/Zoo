using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Crocodile : Animal
    {
        public int NbrTeeth { get; set; }
        public string FavFood { get; set; }

        public void CreatedCrocodile(Crocodile croc, ref int numberTeeth)
        {
            bool Flag;
            do
            {
                Console.WriteLine("Please enter {0}'s number of teeth: ", croc.Name);
                string entry = Console.ReadLine();
                Flag = Validation.ForIntegers(entry, ref numberTeeth);
            } while (Flag == false);

            Console.WriteLine("{0}'s number of teeth is {1}.", croc.Name, numberTeeth);
        }

        public void FavouriteFood(Crocodile croc, ref string favourite)
        {
            bool Flag = false;
            string fav;
            do
            {
                Console.WriteLine("Please enter {0}'s favourite food: ", croc.Name);
                fav = Console.ReadLine();
                if (string.IsNullOrEmpty(fav))
                {
                    Console.WriteLine("{0}'s favourite food mustn't be empty.", croc.Name);                    
                }                
                else if (fav.Any(char.IsDigit))
                {
                    Console.WriteLine("{0}'s favourite food mustn't contain numbers.", croc.Name);
                }
                else
                {
                    fav = fav.Substring(0, 1).ToUpper() + fav.Substring(1); //to turn the first word's letter into a capital letter
                    Console.WriteLine("{0}'s favourite food is {1}.", croc.Name, fav);
                    Flag = true;
                }
            } while (Flag == false);

            favourite = fav;
        }
    }
}

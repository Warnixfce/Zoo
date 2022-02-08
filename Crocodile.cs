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
            int numberTeethValid;
            bool Flag = false;
            do
            {
                Console.WriteLine("Please enter {0}'s number of teeth: ", croc.Name);
                string number = Console.ReadLine();

                if (!int.TryParse(number, out numberTeethValid))
                {
                    Console.WriteLine("You must enter a number.");                    
                }
                else if (numberTeethValid < 0)
                {
                    Console.WriteLine("You must enter zero or a positive number.");                    
                }
                else
                {
                    Console.WriteLine("{0}'s number of teeth is {1}.", croc.Name, numberTeethValid);     
                    Flag = true;
                }
            } while (Flag == false);

            numberTeeth = numberTeethValid;
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
                    Console.WriteLine("{0}'s favourite food is {1}.", croc.Name, fav);
                    Flag = true;
                }
            } while (Flag == false);

            favourite = fav;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Zoo
{
    class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int NbrLegs { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }

        public void PrintDescription()
        {
            List<Animal> CurrentAnimalsInZoo = new List<Animal>(Zoo.GetList());
            if (CurrentAnimalsInZoo.Count() == 0)
            {
                Console.WriteLine("Unable to show a description. There are no animals in the zoo.");
            }
            else
            {
                string speciesDescrip;
                string nameDescrip;
                string genderDescip;
                Animal animalToPrintDescription = new Animal();

                Console.WriteLine("Please enter the species of the animal you wish to know it's description: ");
                speciesDescrip = Console.ReadLine();
                speciesDescrip = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(speciesDescrip.ToLower());

                Console.WriteLine("Please enter the name of the animal you wish to know it's description: ");
                nameDescrip = Console.ReadLine();
                nameDescrip = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameDescrip.ToLower());

                Console.WriteLine("Please enter the gender of the animal you wish to know it's description: ");
                genderDescip = Console.ReadLine().ToUpper();

                animalToPrintDescription = CurrentAnimalsInZoo.Find(A => A.Species == speciesDescrip && A.Name == nameDescrip && A.Gender == genderDescip);

                if (animalToPrintDescription == null)
                {
                    Console.WriteLine("There is no animal with the species \'{0}\', name \'{1}\' and gender \'{2}\' in the zoo. Please enter an animal that exists in the zoo.", speciesDescrip, nameDescrip, genderDescip);
                }
                else
                {
                    Console.WriteLine("The description of the animal with species \'{0}\', name \'{1}\' and gender \'{2}\' is: \n{3}.", speciesDescrip, nameDescrip, genderDescip, animalToPrintDescription.Description);
                }
            }          
            
        }

    }
}

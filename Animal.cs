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
                bool Flag;
                Animal animalToPrintDescription = new Animal();

                do
                {
                    Console.WriteLine("Please enter the species of the animal you wish to know it's description: ");
                    speciesDescrip = Console.ReadLine();
                    Flag = Validation.StringValidation(speciesDescrip, "species");
                    speciesDescrip = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(speciesDescrip.ToLower());

                } while (Flag == false);

                do
                {
                    Console.WriteLine("Please enter the name of the animal you wish to know it's description: ");
                    nameDescrip = Console.ReadLine();
                    Flag = Validation.StringValidation(nameDescrip, "name");
                    nameDescrip = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameDescrip.ToLower());

                } while (Flag == false);

                do
                {
                    Console.WriteLine("Please enter 'M' (Male) or 'F' (Female) as the gender of the animal you wish to know it's description: ");
                    genderDescip = Console.ReadLine().ToUpper();
                    Flag = Validation.OptionValidation(genderDescip, "gender", "M", "F");
                } while (Flag == false);
                

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

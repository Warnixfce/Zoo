using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Zoo
{
    class Zoo
    {
        //hardcoded, just for practice THIS IS A TEST ADC
        public string Name = "ZooWorld";
        public string City = "Buenos Aires";
        public string OpHours = "from 9:00 a.m. to 6:00 p.m. Monday to Friday. And from 9:00 a.m. to 7:00 p.m. Saturdays and Sundays";

        private static List<Animal> AnimalsInZoo = new List<Animal>();

        public void QuantityInZoo()
        {
            if (AnimalsInZoo.Count() == 0)
            {
                Console.WriteLine("There are no animals in the zoo.");
            }
            else if (AnimalsInZoo.Count() == 1)
            {
                Console.WriteLine("There is 1 animal in the zoo.");
            }
            else
            {
                Console.WriteLine("There are {0} animals in the zoo.", AnimalsInZoo.Count());
            }       
        }

        public void AddAnimal()
        {
            bool Flag;            
            string animalSpecies;
            string animalName;
            string animalNbrLegs;
            int animalLegsValid;
            string animalGender;
            string animalDescription;

            Animal animalToAdd = new Animal();

            do
            {
                Console.WriteLine("Please enter the species of the animal you wish to add: ");
                animalSpecies = Console.ReadLine();
                Flag = StringValidation(animalSpecies, "species");
                animalSpecies = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(animalSpecies.ToLower());

            } while (Flag == false);

            do
            {
                Console.WriteLine("Please enter the name of the animal you wish to add: ");
                animalName = Console.ReadLine();
                Flag = StringValidation(animalName, "name");
                animalName= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(animalName.ToLower());

            } while (Flag == false);            

            do
            {
                Console.WriteLine("Please enter the number of legs of the animal you wish to add: ");
                animalNbrLegs = Console.ReadLine();

                if (!int.TryParse(animalNbrLegs, out animalLegsValid))
                {
                    Console.WriteLine("You must enter a number.");
                    Flag = false;
                }
                else if (animalLegsValid < 0)
                {
                    Console.WriteLine("You must enter zero or a positive number.");
                    Flag = false;
                }
                else
                {                    
                    Flag = true;
                }
            } while (Flag == false);

            do
            {
                Console.WriteLine("Please enter 'M' (Male) or 'F' (Female) as the gender of the animal you wish to add: ");
                animalGender = Console.ReadLine().ToUpper();
                Flag = OptionValidation(animalGender, "gender", "M", "F");               
            } while (Flag == false);

            do
            {
                Console.WriteLine("Please enter the description of the animal you wish to add: ");
                animalDescription = Console.ReadLine();
                if (string.IsNullOrEmpty(animalDescription))
                {
                    Console.WriteLine("The description mustn't be empty.");
                    Flag = false;
                }
                else
                {   
                    Flag = true;
                    animalDescription = animalDescription.Substring(0,1).ToUpper() + animalDescription.Substring(1);
                }
            } while (Flag == false);

            if (animalSpecies == "Giraffe")
            {
                bool option;
                string compare;
                float animalHeight = 0;
                Giraffe giraffe = new Giraffe
                {
                    Species = "Giraffe",
                    Name = animalName,
                    NbrLegs = animalLegsValid,
                    Gender = animalGender,
                    Description = animalDescription
                };
                giraffe.CreatedGiraffe(giraffe, ref animalHeight);
                giraffe.Height = animalHeight;

                AnimalsInZoo.Add(giraffe);
                Console.WriteLine("\nCongratulations! You added a new animal to the zoo. This is a sum up of the information about it:" +
                    "\nSpecies: Giraffe. \nName: {0}. \nNumber of Legs: {1}. \nGender: {2}. \nDescription: {3}. \nHeight: {4}m.", 
                    animalName, animalLegsValid, animalGender, animalDescription, animalHeight);
                
                do
                {
                    Console.WriteLine("Do you wish to compare {0}'s height to the average? (Y/N)", giraffe.Name);
                    compare = Console.ReadLine().ToUpper();
                    option = OptionValidation(compare, "entry", "Y", "N");
                    if(compare == "Y")
                    {
                        giraffe.CompareHeight(giraffe);
                    }
                    else
                    {
                        Console.WriteLine("\nRedirecting to menu...");
                    }
                } while (option == false);
            }

            else if (animalSpecies == "Crocodile")
            {
                int animalNumberTeeth = 0;
                string animalFavourite = "";
                Crocodile crocodile = new Crocodile
                {
                    Species = "Crocodile",
                    Name = animalName,
                    NbrLegs = animalLegsValid,
                    Gender = animalGender,
                    Description = animalDescription
                };
                crocodile.CreatedCrocodile(crocodile, ref animalNumberTeeth);
                crocodile.NbrTeeth = animalNumberTeeth;
                crocodile.FavouriteFood(crocodile, ref animalFavourite);
                crocodile.FavFood = animalFavourite;

                AnimalsInZoo.Add(crocodile);
                Console.WriteLine("\nCongratulations! You added a new animal to the zoo. This is a sum up of the information about it:" +
                    "\nSpecies: Crocodile. \nName: {0}. \nNumber of Legs: {1}. \nGender: {2}. \nDescription: {3}. \nNumber of Teeth: {4}. \nFavourite food: {5}."
                    , animalName, animalLegsValid, animalGender, animalDescription, animalNumberTeeth, animalFavourite);                
            }

            else if (animalSpecies == "Giant Tortoise")
            {
                float animalAge = 0;
                Giant_Tortoise tortoise = new Giant_Tortoise
                {
                    Species = "Giant Tortoise",
                    Name = animalName,
                    NbrLegs = animalLegsValid,
                    Gender = animalGender,
                    Description = animalDescription
                };
                tortoise.CreatedGiantTortoise(tortoise, ref animalAge);
                tortoise.Age = animalAge;
                tortoise.Youth(tortoise);

                AnimalsInZoo.Add(tortoise);
                Console.WriteLine("\nCongratulations! You added a new animal to the zoo. This is a sum up of the information about it:" +
                    "\nSpecies: Giant Tortoise. \nName: {0}. \nNumber of Legs: {1}. \nGender: {2}. \nDescription: {3}. \nAge: {4} years."
                    , animalName, animalLegsValid, animalGender, animalDescription, animalAge);
            }

            else
            {
                animalToAdd.Species = animalSpecies;
                animalToAdd.Name = animalName;
                animalToAdd.NbrLegs = animalLegsValid;
                animalToAdd.Gender = animalGender;
                animalToAdd.Description = animalDescription;

                AnimalsInZoo.Add(animalToAdd);                
                Console.WriteLine("\nCongratulations! You added a new animal to the zoo. This is a sum up of the information about it:" +
                    "\nSpecies: {0}. \nName: {1}. \nNumber of Legs: {2}. \nGender: {3}. \nDescription: {4}.", animalSpecies, animalName, animalLegsValid, animalGender, animalDescription);
            }          
        }

        public void RemoveAnimal()
        {
            if(AnimalsInZoo.Count() == 0)
            {
                Console.WriteLine("Unable to remove an animal. There are no animals currently living in the zoo. Please come back later.");
            }
            else
            {
                Animal animalToRemove;
                bool Flag;
                string speciesToRemove;
                string nameToRemove;

                do
                {
                    Console.WriteLine("Please enter the species of the animal you wish to remove: ");
                    speciesToRemove = Console.ReadLine();
                    Flag = StringValidation(speciesToRemove, "species");
                    speciesToRemove = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(speciesToRemove.ToLower());

                } while (Flag == false);

                do
                {
                    Console.WriteLine("Please enter the name of the animal you wish to remove: ");
                    nameToRemove = Console.ReadLine();
                    Flag = StringValidation(nameToRemove, "name");
                    nameToRemove = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameToRemove.ToLower());

                } while (Flag == false);
                

                animalToRemove = AnimalsInZoo.Find(A => A.Species == speciesToRemove && A.Name == nameToRemove);

                if (animalToRemove == null)
                {
                    Console.WriteLine("There is no animal with the species \'{0}\' and the name \'{1}\' in the zoo. Please enter an animal that exists in the zoo.", speciesToRemove, nameToRemove);
                }
                else
                {
                    AnimalsInZoo.Remove(animalToRemove);
                    Console.WriteLine("The animal with species \'{0}\' and name \'{1}\' has been successfully removed from the zoo.", speciesToRemove, nameToRemove);
                }
            }            
        }

        public void AnimalDescriptions()
        {
            string nameDescrption = "";

            foreach(Animal A in AnimalsInZoo)
            {
                nameDescrption += "Species: " + A.Species + " -  Name: " + A.Name + " - Description: " + A.Description + "." + System.Environment.NewLine;
            }
            if(string.IsNullOrEmpty(nameDescrption))
            {
                Console.WriteLine("Unable to show descriptions of the animals. There are no animals currently living in the zoo. Please come back later.");
            }
            else
            {
                Console.WriteLine("Descriptions of all animals currently living in the zoo: " + System.Environment.NewLine + nameDescrption);
            }            
        }

        public void PrintDescription()
        {
            Animal a = new Animal();
            a.PrintDescription();
        }

        public void AdmissionPrice()
        {
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            if(wk == DayOfWeek.Saturday || wk == DayOfWeek.Sunday)
            {
                Console.WriteLine("Since today is {0}, the admission price is $25.99.", wk);
            }
            else if (wk == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Since today is {0}, the admission price is $9.99.", wk);
            }
            else 
            {
                Console.WriteLine("Since today is {0}, the admission price is $19.99.", wk);
            }
        }

        

        public bool StringValidation(string characters, string type)
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

        public bool OptionValidation(string option, string type, string char1, string char2)
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

        public static List<Animal> GetList()
        {
            return AnimalsInZoo;
        }
    }
}

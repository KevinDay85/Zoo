using System;
using System.Collections.Generic;

namespace zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo z = new Zoo();
            z.Print();
            
            int id = 0;
            string input = "";
            string inputType = "";
            string inputName = "";

            while (input != "exit")
            {
                Console.WriteLine("What do you want to do? (create, delete or print)");

                input = Console.ReadLine();
                switch (input)
                {
                    case "create":
                        // Create an animal
                        
                        Console.WriteLine("What type of animal would you like to create?(Mammal, Bird, Fish, etc.)");
                        inputType = Console.ReadLine();

                        Console.WriteLine("Enter the name of the animal you wish to create");
                        inputName = Console.ReadLine();

                        Animal newAnimal = new Animal(inputName, inputType, id++ );
                        z.ZooList.Add(newAnimal);
                         Console.WriteLine("Greetings from " + inputName);
                        Console.WriteLine("New animal was created");
                       
                        newAnimal.Print();

                        

                        break;



                    case "delete":
                        // delete animal by ID

                        Console.WriteLine("Delete animal by Id");
                        int animalId = int.Parse(Console.ReadLine());
                        Animal tempAnimal = new Animal();
                        
                        foreach(Animal an in z.ZooList)
                        {
                            if(an.Id == animalId)
                            {
                                tempAnimal = an;
                            }
                        }

                        z.ZooList.Remove(tempAnimal);

                        break;
                    case "print":
                        // Print out all animals

                        foreach(Animal an in z.ZooList)
                        {
                            an.Print();
                        }

                        break;
                }
            }
        }

    }
}

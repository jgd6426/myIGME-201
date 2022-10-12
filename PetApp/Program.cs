using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetApp
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE13 - More Classes
    // Restrictions: None
    static internal class Program
    {
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }
        public abstract class Pet
        {
            private string name;
            public int age;

            public string Name;

            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();


        }
        public class Pets
        {
            public List<Pet> petList = new List<Pet>();

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public int Count 
            { 
                get petList.Count; 
            }

            public void Add(Pet pet)
            {
                petList.Add(pet);
            }

            public void Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
            }
        }

        public class Cat: Pet, ICat
        {
            public override void Eat()
            {
                Console.WriteLine("Cat is eating tuna.");
            }
            public override void Play()
            {
                Console.WriteLine("Cat is playing with a random bottle cap.");
            }
            public void Purr()
            {
                Console.WriteLine("Cat is vibrating");
            }
            public void Scratch()
            {
                Console.WriteLine("Ouch! Cat has knifes.");
            }
            public override void GotoVet()
            {
                Console.WriteLine("Cat is at the doctors.");
            }
        }

        public class Dog: Pet, IDog
        {
            public string license;

            public override void Eat()
            {
                Console.WriteLine("Dog is eating floor spaghetti.");
            }
            public override void Play()
            {
                Console.WriteLine("Dog is winning at tug-of-war.");
            }
            public void Bark()
            {
                Console.WriteLine("Dog is talking to you.");
            }
            public void NeedWalk()
            {
                Console.WriteLine("Dog needs to go touch grass.");
            }
            public override void GotoVet()
            {
                Console.WriteLine("Dog is at the doctors.");
            }
        }

        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            start:
            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog
                        dog = new Dog();
                    }
                    else
                    {
                        // else add a cat
                        cat = new Cat();
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = new Pets.petList[rand];
                    if (thisPet == null)
                    {
                        goto start;
                    }
                }
            }

            if (thisPet.GetType() == Dog)
            {
                iDog = thisPet;
            }
            else
            {
                iCat = thisPet;
            }
        }
    }
}

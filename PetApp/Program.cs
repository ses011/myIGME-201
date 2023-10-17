using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Author: Sarah Schneider
 * 
 */
namespace PetApp {
    internal class Program {
        static void Main(string[] args) {
            Pet thisPet = null;
            //Dog dog = null;
            //Cat cat = null;       // Given variable declarations that are never used
            IDog iDog = null;
            ICat iCat = null;
            int method;
            Pets pets = new Pets();

            Random rand = new Random();

            for (int i = 0; i < 50; i++) {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1) {
                    if (rand.Next(0, 2) == 0) {
                        // get dog parameters
                        Console.Write("You got a dog!\nDog's Name => ");
                        String name = Console.ReadLine();

                        Console.Write("Age => ");
                        int age;
                        while (true) {
                            try {
                                age = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch {
                                Console.Write("Age => ");
                            }
                        }

                        Console.Write("License => ");
                        String license =(Console.ReadLine());


                        pets.Add(new Dog(license, name, age));
                    }
                    else {
                        // get cat parameters
                        
                        Console.Write("You got a cat!\nCat's Name => ");
                        String name = Console.ReadLine();

                        Console.Write("Cat's Age => ");
                        int age;
                        while (true) {
                            try {
                                age = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch {
                                Console.Write("Cat's Age => ");
                            }
                        }

                        pets.Add(new Cat(name, age));
                    }
                }
                else {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    
                    thisPet = pets[rand.Next(0, pets.Count)];
                    if (thisPet == null) {
                        continue;
                    }
                    else {
                        try {
                            iDog = (IDog)thisPet;
                        }
                        catch {
                            try {
                                iCat = (ICat)thisPet;
                            }
                            catch { }
                        }
                        

                        
                        //Generates a random number depending on the type of object
                        if(iDog is IDog) {
                            method = rand.Next(3, 7);
                        }
                        else if (iCat is ICat){
                            method = rand.Next(1, 4);
                        }
                        else {
                            method = 0;
                        }


                        // cases 3 and 4, Eat and Play methods, are methods that are shared by both classes
                        // calling them on the thisPet object will still result in the respective version of the method being called
                        switch (method) {
                            case 1: 
                                iCat.Scratch();
                                break;
                            case 2:
                                iCat.Purr();
                                break;
                            case 3:
                                thisPet.Eat();
                                break;
                            case 4:
                                thisPet.Play();
                                break;
                            case 5:
                                iDog.Bark();
                                break;
                            case 6:
                                iDog.GoToVet();
                                break;
                            case 7:
                                iDog.NeedWalk();
                                break;
                            default: 
                                Console.WriteLine("uhoh"); 
                                break;
                        }
                    }
                }
            }
        }

        public class Pets {
            public List<Pet> petList = new List<Pet>();

            public Pet this[int nPetEl] {
                get {
                    Pet returnVal;
                    try {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count) {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public int Count {
                get {
                    return petList.Count;
                }
            }

            public void Add(Pet pet) {
                petList.Add(pet);
            }

            public void Remove(Pet pet) {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl) {
                petList.RemoveAt(petEl);
            }
        }

        public abstract class Pet {
            private String name;
            public int age;

            public Pet() {

            }

            public Pet(String name, int age) {
                this.name = name;
                this.age = age;
            }

            public String Name {
                get {
                    return name;
                }
                set {
                    name = value;
                }
            }

            public abstract void Eat();

            public abstract void Play();
        }

        public interface IDog {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GoToVet();
        }

        public interface ICat {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

        public class Dog : Pet, IDog {
            public String license;
            public Dog(String szLicense, String szName, int nAge) : base(szName, nAge) {
                license = szLicense;
            }

            
            public override void Eat() {
                Console.WriteLine(this.Name + ": nom");
            }

            public override void Play() {
                Console.WriteLine(this.Name + ": nyoom");
            }

            public void Bark() {
                Console.WriteLine(this.Name + ": woof");
            }

            public void NeedWalk() {
                Console.WriteLine(this.Name + ": walk?? walk?!? walk???? WALK!!? WALK?!!! WALK WALK WALK WAL-");
            }

            public void GoToVet() {
                Console.WriteLine(this.Name + ": nope, bad. nope nope nope-");
            }
        }

        public class Cat : Pet, ICat {
            public Cat(String name, int age) : base(name, age){ }

            public override void Eat() {
                Console.WriteLine(Name + ": steals another cat's food");
            }

            public override void Play() {
                Console.WriteLine(Name + ": decides your foot is it's new favorite toy");
            }

            public void Scratch() {
                Console.WriteLine(Name + ": has scratched you- you will be scarred for the next 3 months");
            }

            public void Purr() {
                Console.WriteLine(Name + ": congrats- they don't hate what you're doing");
            }
        }
    }
}

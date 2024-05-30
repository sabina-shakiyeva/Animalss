using ConsoleApp2;
class Program
{
    static void Main(string[] args)
    {
        PetShop petShop = new PetShop();
        Cat cat1 = new Cat("Mestan", 2, "woman", 50, 300, 3);

        Dog dog1 = new Dog("Rolly", 4, "male", 80, 400, 2);


        Bird bird1 = new Bird("Dafi", 1, "male", 20, 100, 4);

        Fish fish1 = new Fish("Babi", 1, "male", 10, 50, 2);

        petShop.cats.Add(cat1);
        petShop.birds.Add(bird1);
        petShop.fishh.Add(fish1);
        petShop.dogs.Add(dog1);


        List<Animals> animals = new List<Animals>();
        animals.Add(cat1);
        animals.Add(dog1);
        animals.Add(bird1);
        animals.Add(fish1);

        while (true)
        {
           
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. sleep");
            Console.WriteLine("3. play");
            Console.WriteLine("4. Total Price");
            Console.WriteLine("5. Total Meal");
            Console.WriteLine("6. Print");
            Console.WriteLine("7. Exit");
         

            Console.Write(" choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("yemek vermek istediyin heyvanin adi: ");
                string feed = Console.ReadLine();
                foreach (var cat in petShop.cats)
                {
                    if (cat.Nickname == feed)
                    {
                        cat.Eat();
                        break;
                    }
                }
                foreach (var dog in petShop.dogs)
                {
                    if (dog.Nickname == feed)
                    {
                        dog.Eat();
                        break;
                    }
                }
                foreach (var bird in petShop.birds)
                {
                    if (bird.Nickname == feed)
                    {
                        bird.Eat();
                        break;
                    }
                }
                foreach (var fish in petShop.fishh)
                {
                    if (fish.Nickname == feed)
                    {
                        fish.Eat();
                        break;
                    }
                }

            }
            else if(choice == 2) {
                Console.Write("Enter the nickname of the pet you want to put to sleep: ");
                string sleepPet = Console.ReadLine();
                foreach (var cat in petShop.cats)
                {
                    if (cat.Nickname == sleepPet)
                    {
                        if (cat.Energy == 0)
                        {
                            Console.WriteLine($"{cat.Nickname} is too tired and falls asleep.");
                            cat.Sleep();
                        }
                        else
                        {
                            Console.WriteLine($"{cat.Nickname} is  well-rested.");
                        }
                        break;
                    }
                }
                foreach (var dog in petShop.dogs)
                {
                    if (dog.Nickname == sleepPet)
                    {
                        if (dog.Energy == 0)
                        {
                            Console.WriteLine($"{dog.Nickname} is too tired and falls asleep.");
                            dog.Sleep();
                        }
                        else
                        {
                            Console.WriteLine($"{dog.Nickname} is  well-rested.");
                        }
                        break;
                    }
                }
                foreach (var bird in petShop.birds)
                {
                    if (bird.Nickname == sleepPet)
                    {
                        if (bird.Energy == 0)
                        {
                            Console.WriteLine($"{bird.Nickname} is too tired and falls asleep.");
                            bird.Sleep();
                        }
                        else
                        {
                            Console.WriteLine($"{bird.Nickname} is  well-rested.");
                        }
                        break;
                    }
                }
                foreach (var fish in petShop.fishh)
                {
                    if (fish.Nickname == sleepPet)
                    {
                        if (fish.Energy == 0)
                        {
                            Console.WriteLine($"{fish.Nickname} is too tired and falls asleep.");
                            fish.Sleep();
                        }
                        else
                        {
                            Console.WriteLine($"{fish.Nickname} is  well-rested.");
                        }
                        break;
                    }
                }

            }
            else if (choice == 3)
            {
                Console.Write("oynamaq istediyiniz heyvanin adi: ");
                string playy = Console.ReadLine();
                foreach (var cat in petShop.cats)
                {
                    if (cat.Nickname == playy)
                    {
                        cat.Play();
                        break;
                    }
                }
                foreach (var dog in petShop.dogs)
                {
                    if (dog.Nickname == playy)
                    {
                        dog.Play();
                        break;
                    }
                }
                foreach (var bird in petShop.birds)
                {
                    if (bird.Nickname == playy)
                    {
                        bird.Play();
                        break;
                    }
                }
                foreach (var fish in petShop.fishh)
                {
                    if (fish.Nickname == playy)
                    {
                        fish.Play();
                        break;
                    }
                }
            }
          
            else if(choice == 4)
            { 
                int totalCatPrice = petShop.TotalCatPrice();

                
                int totalDogPrice = petShop.TotalDogPrice();

              
                int totalBirdPrice = petShop.TotalBirdPrice();

                
                int totalFishPrice = petShop.TotalFishPrice();

               
                Console.WriteLine("Total cat price: $" + totalCatPrice);

                
                Console.WriteLine("Total dog price: $" + totalDogPrice);

              
                Console.WriteLine("Total bird price: $" + totalBirdPrice);
        
                Console.WriteLine("Total fish price: $" + totalFishPrice);
            }
            else if (choice == 5)
            {
                int totalCatMealQuantity = petShop.TotalCatMeal();
                int totalDogMealQuantity = petShop.TotalDogMeal();
                int totalBirdMealQuantity = petShop.TotalBirdMeal();
                int totalFishMealQuantity = petShop.TotalFishMeal();

                Console.WriteLine("Total cat meal quantity: " + totalCatMealQuantity);
                Console.WriteLine("Total dog meal quantity: " + totalDogMealQuantity);
                Console.WriteLine("Total bird meal quantity: " + totalBirdMealQuantity);
                Console.WriteLine("Total fish meal quantity: " + totalFishMealQuantity);

            }
            else if(choice == 6)
            {
               foreach(var animal in animals)
                {
                    Console.WriteLine(animal.ToString());
                }   
            
            }
            else if(choice == 7)
            {
                break;
            }
           


        }

    }
}
      

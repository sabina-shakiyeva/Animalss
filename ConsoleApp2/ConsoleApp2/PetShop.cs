using ConsoleApp2;

public class PetShop
{
    public List<Cat> cats { get; set; } = new List<Cat>();
    public List<Dog> dogs { get; set; } = new List<Dog>();
    public List<Bird> birds { get; set; } = new List<Bird>();
    public List<Fish> fishh { get; set; } = new List<Fish>();

   
  

    public int TotalCatMeal()
    {
        int totalCatMeal = 0;
        foreach (var cat in cats)
        {
            totalCatMeal += cat.MealQuantity;
        }
        return totalCatMeal;
    }
    public int TotalDogMeal()
    {
        int totalDogMeal = 0;
        foreach (var dog in dogs)
        {
            totalDogMeal += dog.MealQuantity;
        }
        return totalDogMeal;
    }
    public int TotalBirdMeal()
    {
        int totalBirdMeal = 0;
        foreach (var bird in birds)
        {
            totalBirdMeal += bird.MealQuantity;
        }
        return totalBirdMeal;

    }
    public int TotalFishMeal()
    {
        int totalFishMeal = 0;
        foreach (var bird in birds)
        {
            totalFishMeal += bird.MealQuantity;
        }
        return totalFishMeal;
    }
    public int TotalCatPrice()
    {
        int totalCatPrice = 0;
        foreach (var cat in cats)
        {
            totalCatPrice += cat.Price;
        }
        return totalCatPrice;

    }
    public int TotalDogPrice()
    {
        int TotalDogPrice = 0;
        foreach (var dog in dogs)
        {
            TotalDogPrice += dog.Price;
        }
        return TotalDogPrice;

    }
    public int TotalBirdPrice()
    {
        int TotalBirdPrice = 0;
        foreach (var bird in birds)
        {
            TotalBirdPrice += bird.Price;
        }
        return TotalBirdPrice;

    }
    public int TotalFishPrice()
    {
        int TotalFishPrice = 0;
        foreach (var fish in fishh)
        {
            TotalFishPrice += fish.Price;
        }
        return TotalFishPrice;

    }


    public void RemoveByNickName(string nickname)
    {
        foreach (var cat in cats)
        {
            if (cat.Nickname == nickname) {
                cats.Remove(cat);
                break;
            }
        }
        foreach (var dog in dogs)
        {
            if(dog.Nickname == nickname)
            {
                dogs.Remove(dog);
                break;
            }
        }
        foreach(var bird in birds)
        {
            if (bird.Nickname == nickname) { 
                birds.Remove(bird);
                break;
            }
        }
        foreach(var fish in fishh)
        {
            if(fish.Nickname == nickname)
            {
                fishh.Remove(fish);
                break;
            }
        }
    }
}

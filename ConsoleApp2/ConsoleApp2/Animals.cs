using System.Xml.Linq;

namespace ConsoleApp2;

public class Animals
{
    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public int Energy { get; set; }
    public int Price { get; set; }
    public int MealQuantity { get; set; }

    public Animals(string nickname, int age, string gender, int energy, int price, int mealQuantity)
    {
        Nickname = nickname;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }

    public override string ToString() =>
       $"Nickname:{Nickname}\nAge:{Age}\nGender:{Gender}\nEnergy:{Energy}\nPrice:{Price}\nMealQuantity:{MealQuantity}";
    public virtual void Eat()
    {
        MealQuantity += 1;
        Energy += 20;
        Price += 10;


    }
    public virtual void Sleep()
    {
        Energy += 30;

    }
    public virtual void Play()
    {
        if (Energy >= 10)
        {
            Energy -= 10;
            Console.WriteLine("Animal is playing");
        }
        else
        {
            Console.WriteLine("can't play");
        }
    }
}

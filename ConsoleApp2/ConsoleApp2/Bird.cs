namespace ConsoleApp2;

public class Bird :  Animals
{
    public Bird(string nickname, int age, string gender, int energy, int price, int mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
    {
    }
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Bird is eating");
    }
    public override void Sleep()
    {
        base.Sleep();
        if (Energy == 0)
        {
            Console.WriteLine("Bird is Sleeping");
        }
    }
    public override void Play()
    {
        base.Play();
        
    }
}

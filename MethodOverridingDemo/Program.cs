namespace MethodOverridingDemo;

class Program
{
    static void Main(string[] args)
    {
        PersonModel person = new PersonModel
        {
            FirstName = "Tim",
            LastName = "Corey",
            Email = "blah@gmail.com"
        };

        Console.WriteLine(person.ToString());

        Console.ReadLine();
    }
}

public abstract class Car
{
    public virtual void StartCar()
    {
        Console.WriteLine("Turn key and start");
    }

    public abstract void SetClock();
}

public class Corolla : Car
{
    public override void SetClock()
    {
        Console.WriteLine("Fiddle with the Corolla clock.");
    }
}

public class Tesla : Car
{
    public override void StartCar()
    {
        Console.WriteLine("Think about your destination.");
    }
    public override void SetClock()
    {
        Console.WriteLine("It sets itself.");
    }
}
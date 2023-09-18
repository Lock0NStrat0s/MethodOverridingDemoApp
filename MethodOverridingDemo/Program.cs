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

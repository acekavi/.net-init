using System;

namespace HelloWorld
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ace = new Person("Ace", "Ventura", new DateOnly(1999, 09, 10));
            // Console.WriteLine($"Name: {ace.Name}");
            // Console.WriteLine($"Gender: {ace.Sex}");

            var rashmika = new Person("Rashmika", "Mandanna", new DateOnly(1996, 09, 19), "Female");
            // Console.WriteLine($"Name: {rashmika.Name}");
            // Console.WriteLine($"Gender: {rashmika.Sex}");

            rashmika.Pets.Add(new Dog("Lilly"));
            rashmika.Pets.Add(new Cat("Panda"));

            List<Person> people = [ace, rashmika];
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.ToString()}");
                foreach (var pet in person.Pets)
                {
                    Console.WriteLine($"I'm {pet.ToString()} who can {pet.MakeNoise()}");
                }
            }
        }
    }
}

class Person(
    string firstName,
    string lastName,
    DateOnly birthDate,
    string gender = "Male"
)
{
    public string Name { get; set; } = firstName + " " + lastName;

    public string Sex { get; } = gender;

    public DateOnly BirthDate { get; } = birthDate;

    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"{Name}";
    }
}

public abstract class Pet(
    string name
)
{
    public string Name { get; set; } = name;
    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{Name} and I am a {GetType().Name}";
    }
}

public class Cat(
    string name
) : Pet(name)
{
    public override string MakeNoise()
    {
        return "Meow!";
    }
}

public class Dog(
    string name
) : Pet(name)
{
    public override string MakeNoise()
    {
        return "Bark!";
    }
}
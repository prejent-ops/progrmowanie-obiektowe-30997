// 

class Person
{
    private string name;
    private int age;
    
    public Person(string name, int age)
        {
        this.name = name;
        this.age = age;
        }

    public void introduceYourself()
    {
        Console.WriteLine($"My name is {this.name} is a {this.age} years old.");
    }

    public string Name => name;
    public int Age => age;
}

class Employes : Person
{
    public Employes(string name, int age) : base(name, age)
    { }

}


class Program
{
    static void Main(string[] args)
    {
        Employes em1 =  new Employes("John", 15);
        Person per = em1;
        Console.WriteLine("xd");
        per.introduceYourself();
        
    }
}

// Zadanie 1: Napisz program, który pyta użytkownika o hasło, dopóki nie wpisze poprawnego
//(„admin123”)

using System.Security.Cryptography;

string task1()
{
    string password = "";
    do
    {
        Console.WriteLine("Enter correct your password: \n");
        password = Console.ReadLine();
        return password;
    } while (password != "admin123");
}


//string resultTask1 = task1();
//Console.WriteLine(resultTask1);

int task2()
{
    while (true)
    {
        Console.WriteLine("Enter an positive integer: \n");
        string input = Console.ReadLine();
        int result = int.Parse(input);
        if (result > 0)
        {
            Console.WriteLine("Your number is positive " + input);
            return result;
        }
        else
        {
            Console.WriteLine("Your number must be positive");
        }
    }
}

//int resultTask2 = task2();
//Console.WriteLine($"Your number is positive: {resultTask2}");

void task3()
{
    string[] cities = { "Warsaw", "Krakow", "London", "Poznan", "Lodz" };
    foreach (string city in cities)
    {
        Console.WriteLine(city);
    }
}
task3();
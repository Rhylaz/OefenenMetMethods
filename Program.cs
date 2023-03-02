// Hieronder zie een aantal methoden staan. Roep iedere methode aan, met de juiste parameters. 
// Wanneer de methode iets teruggeeft, zorg je ervoor dat dit op het scherm wordt weergegeven.

SayHello();
GreetUser("Microsoft");
int c = GetRandomNumber();
Console.WriteLine(c);
int square = GetSquare(5);
Console.WriteLine($"Uw output is {square}");
Swap(5, 5);
IsEqual("Ja", "Nee");
PrintNumbers(50, 100);
SumNumbers(50);
PrintMessage();
PrintPerson("Admin", 25);




void SayHello()
{
    Console.WriteLine("Hello!");
}

void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

int GetRandomNumber()
{
    Random rand = new Random();
    return rand.Next(1, 101);
}
int GetSquare(int num)
{
    return num * num;
}
void Swap(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}
bool IsEqual(string str1, string str2)
{
    return str1.Equals(str2);
}
void PrintNumbers(params int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}
int SumNumbers(params int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
void PrintMessage(string message = "Hello!")
{
    Console.WriteLine(message);
}
void PrintPerson(string name, int age = 0)
{
    Console.WriteLine($"Name: {name}, Age: {age}");
}

// Sla 17 op in appelflap
int appelflap = 17;

// Roep GetUsername aan, met userId appelflap
Console.WriteLine(GetUsername(appelflap));

string GetUsername(int userId)
{
    // Get real data from user userId from DB
    return $"User with ID {userId} is called: Wicher";
}





Console.Write("What is your name: ");
string firstName = Console.ReadLine();

Console.Write("What is your age: ");
string ageText = Console.ReadLine();

bool isInt = int.TryParse(ageText, out int age);
string formalName = string.Empty;

// Prefix name if Bob or Sue
if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formalName = "Professor " + firstName;
}
else
{
    formalName = firstName;
}

// Send error if age is not an int
if (!isInt)
{
    Console.WriteLine("You entered an invalid age.");
}
else if (age < 21)
{
    Console.WriteLine($"Please wait {21 - age} years before taking this class, {formalName}");
}
else
{
    Console.WriteLine($"Welcome, {formalName}");
}
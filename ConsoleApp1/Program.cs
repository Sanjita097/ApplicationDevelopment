Console.WriteLine("=== Personal Info Formatter ===");
Console.Write("Enter your name:");
String name = Console.ReadLine();

Console.Write("Enter your address:");
String address = Console.ReadLine();

Console.Write("Enter your phone number:");
String phoneNumber = Console.ReadLine();

Console.Write("Enter your College name:");
string collegeName = Console.ReadLine();

Console.Write("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.Write("How many hobbies do you have?");
int count = int.Parse(Console.ReadLine());

string[] hobbies = new string[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"Enter your hobby #{i + 1}:");
    hobbies[i] = Console.ReadLine();
}

Console.WriteLine("\n----Your Personal Information----");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Address: {address}");
Console.WriteLine($"Phone: {phoneNumber}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"College Name: {collegeName}");
Console.WriteLine($"\n Your Hobbies:");
for (int i= 0; i < hobbies.Length; i++)
{
  Console.WriteLine($"{i + 1}. {hobbies[i]}");  
}
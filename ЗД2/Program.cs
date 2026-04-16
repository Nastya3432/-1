Console.Write("Введите трёхзначное число: ");
string input = Console.ReadLine();

if (input.Length == 3)  
{
    int number = int.Parse(input);
    int firstDigit = number / 100;
    int lastDigit = number % 10;

    Console.WriteLine($"Первая цифра: {firstDigit}");
    Console.WriteLine($"Последняя цифра: {lastDigit}");
}
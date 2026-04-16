Console.Write("Введите трёхзначное число: ");
string number = Console.ReadLine();
char[] arr = number.ToCharArray();
Array.Reverse(arr);
string num = new string(arr);
Console.WriteLine($"Число справа налево: {num}");
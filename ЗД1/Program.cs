Console.Write("Введите радиус: ");
double r = double.Parse(Console.ReadLine());
Console.Write("Введите высоту: ");
double h = double.Parse(Console.ReadLine());
double s = 2 * Math.PI * r * (r + h);
Console.WriteLine($"Площадь поверхности: {s:F2}");

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());

int result = n / m;
int squareResult = result * result;

Console.WriteLine($"Квадрат целочисленного деления {n} на {m}: {squareResult}");
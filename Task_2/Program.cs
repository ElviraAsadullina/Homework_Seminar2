int number = new Random().Next(1, 65536);
Console.WriteLine($"Случайно сгенерированное число: {number}");
if (number < 100)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    Console.WriteLine($"Третья цифра слева данного числа - это {number.ToString()[2]}");
}
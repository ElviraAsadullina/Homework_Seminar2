int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайно сгенерированное число: {num}");
int dozens_count = num / 10;
int digit_middle = dozens_count % 10;
Console.WriteLine ($"Вторая цифра данного числа: {digit_middle}");
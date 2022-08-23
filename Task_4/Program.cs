int number = new Random().Next(1, 1000000);
Console.WriteLine($"Случайно сгенерированное число: {number}");
if (number % 7 ==0 && number % 23 ==0)
{
   Console.WriteLine($"Bingo! Число {number} кратно 7 и 23 одновременно."); 
}
else
{
   Console.WriteLine($"Sorry :( Число {number} не кратно 7 и 23 одновременно."); 
}
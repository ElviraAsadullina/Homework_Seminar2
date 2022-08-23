int day = new Random().Next(1, 7);
Console.WriteLine($"Если день недели посчету {day} -й, то это выходной день?");
switch (day)
{
    case 6:
    case 7:
        Console.WriteLine("Да");
        break;
    default:
        Console.WriteLine("Нет");
        break;
}
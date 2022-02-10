// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int Day;
Console.WriteLine("Введите номер дня недели ");
Day = Convert.ToInt32(Console.ReadLine());
if (Day > 5 && Day < 8) 
{
    Console.Write("Ура!!! Выходной день - ");
    if (Day == 6)
    {
        Console.WriteLine("СБ");
    }
    if (Day == 7)
    {
        Console.WriteLine("ВС");
    }
}
else if (Day > 0 && Day < 6)
{
    Console.WriteLine("Будний день");
}
else 
Console.WriteLine("Нет такого дня");
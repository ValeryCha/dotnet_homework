int max, min;

Console.WriteLine("Введите два числа ");
max = Convert.ToInt32(Console.ReadLine());
min = Convert.ToInt32(Console.ReadLine());

if (max > min)
{
    Console.WriteLine("Наибольшее число " + max);
    Console.WriteLine("Наименьшее число " + min);
}
else if (max < min)
{
    Console.WriteLine("Наименьшее число " + max);
    Console.WriteLine("Наибольшее число " + min);
}
else if (max == min)
{
     Console.WriteLine("Числа равны ");
}

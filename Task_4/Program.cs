// Найти максимальное из трех чисел
int a, b, c;

Console.WriteLine("Введите числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) max = b;

if (c > max) max = c;

Console.WriteLine("Максимальное из трёх чисел - " + max);

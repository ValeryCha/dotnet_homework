// Удалить вторую цифру трёхзначного числа
int a;

Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

int half = a % 10; 
int half1 = a / 100;

Console.WriteLine("Число без второй цифры - " + half1 + half);

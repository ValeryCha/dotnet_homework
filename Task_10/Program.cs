// Показать вторую цифру трёхзначного числа
int a;

Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

int half = a / 10; 
int half1 = half % 10;

Console.WriteLine("Вторая цифра трехзнакочного числа - " + half1);

    
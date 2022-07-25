int a = 2;
int n = 0;

Console.Write("Введите число: ");
bool userEnter = int.TryParse(Console.ReadLine(), out n);

if (userEnter)
{
    Console.WriteLine($"Чётные числа от 1 до {n}:");
    while(a<=n)
    {
        Console.Write($"{a} ");
        a += 2;
    }
}
else Console.Write("Ошибка ввода.");
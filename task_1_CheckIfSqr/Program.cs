int a = 0;
int b = 0;

Console.Write("Введите первое число: ");
bool enterA = int.TryParse(Console.ReadLine(), out a);

Console.Write("Введите второе число: ");
bool enterB = int.TryParse(Console.ReadLine(), out b);

if (enterA && enterB)
    if (a==b*b)
        Console.WriteLine($"Да, число {a} является квадратом чиcла {b}.");
    else
        Console.WriteLine($"Нет, число {a} не явялется квадратом числа {b}.");
else
    Console.Write("Ошибка ввода! Пожалуйста, введите целые числа.");
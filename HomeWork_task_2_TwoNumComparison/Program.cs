// Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = 0;
int b =0;

Console.Write("Введите первое число: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
b = int.Parse(Console.ReadLine());

if(a>b) Console.WriteLine($"Первое число больше второго и является максимальным.\nmax = {a}.");
else if (a<b) Console.WriteLine($"Второе число больше первого и является максимальным.\nmax = {b}.");
else Console.WriteLine("Числа равны.");
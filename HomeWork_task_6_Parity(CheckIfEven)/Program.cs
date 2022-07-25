// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int a = 0;

Console.Write("Введите число: ");
bool userEnter = int.TryParse(Console.ReadLine(), out a);

if(userEnter)
    if(a%2==0) Console.Write($"Число {a} является чётным.");
    else Console.Write($"Число {a} является нечётным.");
else Console.Write("Ошибка ввода.");
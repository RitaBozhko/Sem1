int number = 0;

Console.Write("Введите число: ");
bool userEnter = int.TryParse(Console.ReadLine(), out number);

if(userEnter)
{
    Console.Write($"Квадрат числа {number} равен {number*number}");
}
else{
    Console.Write("Ошибка ввода!");
}
int a = 1;

Console.Write("Какой сегодня по счёту день недели?\nВведите число от 1 до 7: ");

bool userEnter = int.TryParse(Console.ReadLine(), out a);

if(userEnter)
    if(a==1)
        Console.WriteLine("Сегодня Понедельник.");
    else if(a==2)
        Console.WriteLine("Сегодня Вторник.");
    else if(a==3)
        Console.WriteLine("Сегодня Среда.");
    else if(a==4)
        Console.WriteLine("Сегодня Четверг.");
    else if(a==5)
        Console.WriteLine("Сегодня Пятница.");
    else if(a==6)
        Console.WriteLine("Сегодня Суббота.");
    else if (a==7)
        Console.WriteLine("Сегодня Воскресенье.");
    else
        Console.WriteLine("Ошибка ввода. Введите число от 1 до 7.");
else
    Console.WriteLine("Ошибка ввода. Введите целое число от 1 до 7.");
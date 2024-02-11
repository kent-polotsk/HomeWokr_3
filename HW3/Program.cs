/*  1.Рассчитать и вывести на консоль площадь поверхности круглого конусаю.
    Формула S=πr(r+l);
    где r – радиус основания, l – образующая, π (пи)— математическая постоянная;
    Важно! Πи должно быть константой. r и I входные параметры, т е их вводим через консоль.*/

//using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Задание 1");
int radius = 0, height = 0;
bool correctEnter = false;
while (!correctEnter)
{
    Console.WriteLine("Введите радиус конуса: ");
    correctEnter = int.TryParse(Console.ReadLine(), out int result);
    if (correctEnter)
    {
        correctEnter = true;
        radius = result;
    }
    else  Console.WriteLine("Некорректное значение, повторите ввод:");
}
correctEnter = false;
while (!correctEnter)
{
    Console.WriteLine("Введите образующую конуса: ");
    correctEnter = int.TryParse(Console.ReadLine(), out int result);
    if (correctEnter)
    {
        correctEnter = true;
        height = result;
    }
    else Console.WriteLine("Некорректное значение, повторите ввод:");
}
Console.WriteLine($"Площадь поверхности круглого конуса = {Math.PI*radius*(radius+height)}");
Console.ReadKey();

/*  2. Создать консольное приложение, которое будет ожидать ввода символов (чисел),
    Проверять, что число четное.
    Если четное -> вывести на консоль “число {значение} четное”
    Если нечетное -> вывести на консоль “число {значение} нечетное” */

Console.WriteLine();
Console.WriteLine("Задание 2");
string? input;
correctEnter = false;
while (!correctEnter)
{
    Console.WriteLine("Введите число для проверки на четность или Х для выхода: ");
    input = Console.ReadLine();
    correctEnter = int.TryParse(input, out int result);
    if (correctEnter)
    {
        correctEnter = false;
        if (result % 2 == 0)
            Console.WriteLine("Число четное");
        else 
            Console.WriteLine("Число НЕчетное");
    }
    else if (char.TryParse(input, out char resultInput) && (resultInput=='x' || resultInput == 'X' || resultInput == 'Х' || resultInput == 'х'))  break;
    else Console.WriteLine("Некорректное значение, повторите ввод:");
}
Console.ReadKey();

/*3.Имеется 3 переменные типа int x = 14, y = 1, и z = 5; 
    Выведите значения переменных на Console после каждой операции:
    x += y - x++ * z; 
    z = --x – y * 5; 
    y /= x + 5 % z; 
    z = x++ + y * 5; 
    x = y - x++ * z; 
    Какое значение у переменной z в конце алгоритма? Очень советую понять, что каждый оператор делает.*/

Console.WriteLine();
Console.WriteLine("Задание 3");
int x = 14, y = 1, z = 5;
Console.WriteLine($"x = {x} , y = {y} , z = {z}");
Console.WriteLine("Выполнение по отдельности (значения x,y,z для каждого примера равны входным):");
Console.WriteLine($"x += y - x++ * z = {x += y - x++ * z}");
x = 14; y = 1; z = 5;
Console.WriteLine($"z = --x – y * 5 = { --x - y * 5}");
x = 14; y = 1; z = 5;
Console.WriteLine($"y /= x + 5 % z = {y /= x + 5 % z}");        //Ответ неверный в 3 выражении при использовании int, но верный при double
x = 14; y = 1; z = 5;                                  
Console.WriteLine($"z = x++ + y * 5 = { x++ + y * 5}");         //19 сходится
x = 14; y = 1; z = 5;
Console.WriteLine($"x = y - x++ * z = { y - x++ * z}");         //а тут -69, не -74 почему? инкремент имеет приоритет выше чем умножение

x = 14; y = 1; z = 5;
Console.Write("Выполнение последовательно: ");
x += y - x++ * z;
z = --x - y * 5;
y /= x + 5 % z;
z = x++ + y * 5;
x = y - x++ * z;
Console.WriteLine($"x = {x} , y = {y} , z = {z}");
Console.ReadKey();

/*4.С помощью оператора default вывести в консоль дефолтные значения 
    для всех числовых типов данных + типа  int?, типа string, char, bool*/

Console.WriteLine();
Console.WriteLine("Задание 4");
Console.WriteLine($"Дефолтное значение для типа byte = {default(byte)}");
Console.WriteLine($"Дефолтное значение для типа sbyte = {default(sbyte)}");
Console.WriteLine($"Дефолтное значение для типа ushort = {default(ushort)}");
Console.WriteLine($"Дефолтное значение для типа short = {default(short)}");
Console.WriteLine($"Дефолтное значение для типа uint = {default(uint)}");
Console.WriteLine($"Дефолтное значение для типа int = {default(int)}");
Console.WriteLine($"Дефолтное значение для типа int? = {default(int?)}");
Console.WriteLine($"Дефолтное значение для типа ulong = {default(ulong)}");
Console.WriteLine($"Дефолтное значение для типа long = {default(long)}");
Console.WriteLine($"Дефолтное значение для типа float = {default(float)}");
Console.WriteLine($"Дефолтное значение для типа double = {default(double)}");
Console.WriteLine($"Дефолтное значение для типа decimal = {default(decimal)}");
Console.WriteLine($"Дефолтное значение для типа char = {default(char)}");
Console.WriteLine($"Дефолтное значение для типа string = {default(string)}");
Console.WriteLine($"Дефолтное значение для типа string? = {default(string?)}");
Console.WriteLine($"Дефолтное значение для типа bool = {default(bool)}");
Console.ReadKey();


/*5.Создать переменную в которую записать свой рост и вывести 
    в консоль название переменной и значение. Используйте оператор nameof.*/

Console.WriteLine();
Console.WriteLine("Задание 5");
double myHeight = 1.79;
Console.WriteLine($"Название переменной: {nameof(myHeight)}, значение переменной: {myHeight}");
Console.ReadKey();



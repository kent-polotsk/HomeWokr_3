/*  Доп 1
    Необязательное задание * - для тех, кто знаком с C# более-менее и имеет свободное время
    1.Реализовать в C# любой алгоритм нахождение наибольшего общего делителя для неопределенного количества входных чисел.*/

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Дополнительное задание 1. Нахождение наибольшего общего делителя.");

bool correctEnter = false;
string? input;
int arraySize = 2;


while (true)
{
    //Ввод количества чисел (размер массива)
    {
        correctEnter = false;
        while (!correctEnter)
        {
            Console.Write("Введите количество вводимых чисел чисел (не менее 2) или введите х для выхода: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int arraySizeInput))
            {
                if (arraySizeInput >= 2)
                {
                    if (arraySizeInput >= 20)
                        Console.WriteLine("Да ладно, серьезно? какой в этом смысл?))) Введите значение до 20");
                    else
                    {
                        correctEnter = true;
                        arraySize = Convert.ToInt32(input);
                    }
                }
                else Console.WriteLine("Некорректное значение, повторите ввод:");
            }
            else if (char.TryParse(input, out char resultInput) && (resultInput == 'x' || resultInput == 'X' || resultInput == 'Х' || resultInput == 'х'))      return;
            else Console.WriteLine("Некорректное значение, повторите ввод:");
        }
    }


    //Ввод чисел в массив
    int[] myArray = new int[arraySize];
    {
        Console.WriteLine("Введите числа по одному, подтверждая ввод ENTER:");
        correctEnter = false;
            for (int i = 0; i < arraySize; i++)
            {
                while (!correctEnter)
                {
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int intNumber))
                    {
                        correctEnter = true;
                        myArray[i] = Convert.ToInt32(input);
                    }
                    else Console.WriteLine("Некорректное значение, повторите ввод:");
                }
                correctEnter = false;
            }
    }


    //Вычисление НОД
    {
        int first, second, nod = myArray[0];
        for (int i = 0; i <= arraySize - 1; i++)
        {
            first = nod;
            second = myArray[i];

            while (first != second)
            {
                if (first > second)     
                    first -= second;
                else
                    second -= first;
            }
            nod = second;
        }
        Console.WriteLine($"Наибольший общий делитель = {nod}");
    }   
}
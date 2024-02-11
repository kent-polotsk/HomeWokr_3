/* Доп 2 
    2. Дано трехзначное число. Найти:
        а) число единиц в нем;
        б) число десятков в нем;
        в) сумму его цифр;
        г) произведение его цифр.*/
 
Console.OutputEncoding = System.Text.Encoding.UTF8;

string? input = "";
bool correctEnter = false;
int number = 0;


while (true)
{

    //Ввод числа
    {
        correctEnter = false;
        while (!correctEnter)
        {
            Console.Write("Введите трехзначное число или введите х для выхода: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num >= 100 && num < 1000)
                {
                    number = num;
                    correctEnter = true;
                }
                else Console.WriteLine("Некорректное значение, повторите ввод:");
            }
            else if (char.TryParse(input, out char resultInput) && (resultInput == 'x' || resultInput == 'X' || resultInput == 'Х' || resultInput == 'х')) return;
            else Console.WriteLine("Некорректное значение, повторите ввод:");
        }
    }

    //а
    Console.WriteLine($"Число единиц = {input[input.Length-1]}");

    //б
    Console.WriteLine($"Число десятков = {input[input.Length - 2]}");

    //в
    int thousands, tens, units;
    thousands = Convert.ToInt32(Convert.ToString(input[input.Length - 3]));
    tens = Convert.ToInt32(Convert.ToString(input[input.Length - 2]));
    units = Convert.ToInt32(Convert.ToString(input[input.Length - 1]));

    Console.WriteLine($"Сумма цифр = {thousands} + {tens} + {units} = {thousands+tens+units}");

    //г
    Console.WriteLine($"Произведение цифр = {thousands} * {tens} * {units} = {thousands * tens * units}");

}
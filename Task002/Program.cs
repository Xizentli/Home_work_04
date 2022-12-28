/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while(!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ошибка ввода: введено не число.");
        }
    }
    return result;
}

int PrintDigitCount(int number)
{
    int sum = 0; //сумма цифр
    int raz = 0; //переменная для разряда числа

    while(number > 0 || number < 0)
    {
        raz = number % 10;
        number = number / 10;
        sum = sum + raz;
    }
    return sum;
}

int number = GetNumber("Введите число: ");
int sum = PrintDigitCount(number);
Console.WriteLine($"Сумма цифр в числе: {sum}");
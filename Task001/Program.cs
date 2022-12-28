/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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
//Метод возведения в степень
double GetPow(int numberFirst, int numberSecond)
{
    double pow = Math.Pow(numberFirst, numberSecond);
    return pow;
}

int numberFirst = GetNumber("Введите первое число: ");
int numberSecond = GetNumber("Введите второе число: ");
Console.WriteLine($"Число {numberFirst} в степини {numberSecond} = {GetPow(numberFirst, numberSecond)}");
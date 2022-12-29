/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
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

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber($"Введите {i} элемент массива: ");
    }
    return array;
}

int[] array = GetArray();

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
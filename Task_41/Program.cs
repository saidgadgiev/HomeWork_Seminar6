/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

// 1. Ввод корректного сисла
// 2. ввод элементов массива
// 3. посчитать кол чисел больше 0

// ввод корректного размер массива
int CorrectNumber (string messege)
{
    bool isCorrect = false;
    int result = 0;
    while (! isCorrect)
    {
        Console.Write(messege);
        if(int.TryParse(Console.ReadLine(), out result)&& result > 0)
        {
            isCorrect = true;
        }
        else Console.WriteLine("Ввели не корректное число");
        
    }
    return result;
}

// ввод корректного элемента массива

int CorrectNumberArray (string messege)
{
    bool isCorrect = false;
    int result = 0;
    while (! isCorrect)
    {
        Console.Write(messege);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else Console.WriteLine("Ввели не корректное число");
        
    }
    return result;
}

// Создание массива
int[] InitArray(int demensionArray)
{
    int[] array = new int[demensionArray];
    for (int i = 0; i < demensionArray; i++)
    {
        array[i] = CorrectNumberArray($"Введите число {i} элемента массива -> ");
    }
    return array;
}

//Печать массива

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + (i < array.Length-1 ?", ":""));
    }
    Console.Write("] -> ");
}

// подсчет чесел больше 0
void SummNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine(count);
}


int number = CorrectNumber("Введите положительное число для длинны массива! -> ");
int[] array =  InitArray(number);
PrintArray(array);
SummNumber(array);
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine()!;
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

int[] RandomMassive(int val)
{
    int[] array = new int[val];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); 
    }
    return array;
}

void PrintMassive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PrintEven(int[] array)
{
    int count2 = 0;
    int count1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count2++;
        }
        else
        {
            count1++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве равно: {count2} ");
    Console.WriteLine($"Количество НЕ четных чисел в массиве равно: {count1} ");
}

int value = Prompt("Введите длинну массива: ");
int[] arr = RandomMassive(value);
PrintMassive(arr);
Console.WriteLine(" ");
PrintEven(arr);













// int[] Massiv(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size]; // создаем массив
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");

//     }
//     return res;
// }
// void ChangeNum(int[] array)
// {

//     foreach (int el in array)
//     {
//         Console.Write($"{el*(-1)} ");

//     }

// }
// void ChangeNum2(int[] array)
// {
//     int i = 0;
//     foreach (int el in array)
//     {

//         array[i] = el * (-1);
//         Console.Write($"{array[i]} ");
//         i++;

//     }

// }
// void ShowResult(int[] num)
// {
//     Console.WriteLine($"Сумма положительных чисел = {num[0]}, сумма отрицательных чисел = {num[1]}");
// }

// int[] xyz = Massiv(12, -9, 9);
// Console.WriteLine(" ");
// ChangeNum2(xyz);


// void RandomMassive(int val)
// {
//     // int [] array = new int [8];
//     int[] array = new int[val];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);  // генератор [a,b)
//         Console.Write(array[i] + " ");
//     }
// }


// int Prompt(string msg)
// {
//     Console.Write(msg);
//     string value = Console.ReadLine();
//     if ((int.TryParse(value, out int val)) == false)
//     {
//         Console.WriteLine("Это не число ");
//     }
//     return val;
// }
// int value = Prompt("Введите число ");
// RandomMassive(value);
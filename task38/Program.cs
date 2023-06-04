// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();


int Prompt(string msg) // сверка на буквы
{
    Console.Write(msg);
    string value = Console.ReadLine()!;
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

Double[] RandomMassive(int val) // создаем рандомные числа в массиве
{
    Double[] array = new Double[val];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100) / 100.00;
    }
    return array;
}

void OutputMassive(Double[] arr) //выводим массив
{
    Console.Write("Наш массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SumMinMax(Double[] value) //функция подсчета мин и макс значений
{
    Double min = 0;
    Double max = 0;

    Array.Sort(value);

    if (value.Length > 0)
    {
        Console.Write($"Минимальная цифра: {value[0]}");
        min = value[0];
        Console.WriteLine();
        Console.Write($"Максимальная цифра: {value[value.Length - 1]}");
        max = value[value.Length - 1];
    }
    Console.WriteLine();
    Console.Write($"Сумма между максимальной {max} и минимальной {min} цифрой будет: {max - min} ");
}

int value = Prompt("Введите длинну массива: ");
Double[] arr = RandomMassive(value);
OutputMassive(arr);
Console.WriteLine(" ");
SumMinMax(arr);
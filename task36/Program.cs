// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

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
        array[i] = new Random().Next(-100, 100);
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

void PrintEven (int[] value)
{
    int num1 = 0;

    for (int i = 0; i < value.Length; i++)
    {
        if(value[i] % 2 != 0)
        {
            num1 += value[i];
        }
    }

    Console.Write($"Сумма нечетных цифр: {num1} ");
}

int value = Prompt("Введите длинну массива: ");
int[] arr = RandomMassive(value);
PrintMassive(arr);
Console.WriteLine(" ");
PrintEven(arr);
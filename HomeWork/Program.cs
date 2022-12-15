//Домашнее заданиею.
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

int FindNumber(int[] array)
{
    int result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result++;
            Console.WriteLine(array[i]);
        }
    }
    return result;
}

Console.Write("Введите количество элиментов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный размер числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный размер числа: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = FindNumber(myArray);

Console.WriteLine($"Положительных чисел в массиве {result}.");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int SumNumber(int[] array)
{
    int sum = 0;

    for(int i = 1; i <= array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Введите количество элиментов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный размер числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный размер числа: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int res = SumNumber(myArray);

Console.WriteLine($"Сумма чисел на нечетных позициях ровна {res}.");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    double empty = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        empty = new Random().NextDouble();
        empty = Math.Round(empty, 2);
        array[i] += empty;
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

double FindDifferenc(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    dif = max - min;
    dif = Math.Round(dif, 2);
    Console.WriteLine($"Максимальное число {max}.");
    Console.WriteLine($"Минимальное число {min}.");
    return dif;
}

Console.Write("Введите количество элиментов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный размер числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный размер числа: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

double ans = FindDifferenc(myArray);

Console.WriteLine($"Разница между максимальным и минимальным числом ровна {ans}.");
*/
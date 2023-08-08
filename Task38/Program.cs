// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*(max - min) + min;
    }

    return arr;
}

void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
        else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}

double FindMin(double[] arr)
{
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}
int size = 5;
double[] array = CreateArrayRndInt(size, 1, 20); 
PrintArrayDouble(array);
Console.WriteLine();
double min = FindMin(array); 
double max = FindMax(array);
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");

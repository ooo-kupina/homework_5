// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Данная программа выведет массив, заполненный случайными вещественными числами");
Console.WriteLine("в промежутке между 0 и 100, и покажет разницу между максимальным и минимальным элементами массива.");
Console.Write("Введите размер массива - целое число от 1 до 30: ");
int usersize = Convert.ToInt32(Console.ReadLine());

double maxNUM = 0;
double minNUM = 0;

if (usersize > 30 || usersize < 1)
{
    Console.Write("Указанный размер массива задан некорректно. Программа прервана. Введите целое число от 1 до 30. ");
    return;
}

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    array[0] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    maxNUM = array[0];
    minNUM = array[0];

    for (int i = 1; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        if (array[i] > maxNUM)
        {
            maxNUM = array[i];
        }
        if (array[i] < minNUM)
        {
            minNUM = array[i];
        }
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i == array.Length - 1) break;
        Console.Write("; ");
    }
    Console.WriteLine("]");
    Console.Write($"Разница между максимальным {maxNUM} и минимальным {minNUM} элементами массива равна {Math.Round(maxNUM - minNUM, 1)}");
}

double[] arr2 = CreateArrayRndInt(usersize, 0, 100);
PrintArray(arr2);
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Данная программа выведет массив, заполненный случайными положительными трёхзначными числами,");
Console.WriteLine("и покажет количество чётных чисел в массиве.");
Console.Write("Введите размер массива - целое число от 1 до 30: ");
int usersize = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (usersize > 30 || usersize < 1)
{
    Console.Write("Указанный размер массива задан некорректно. Программа прервана. Введите целое число от 1 до 30. ");
    return;
}


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i == array.Length - 1) break;
        Console.Write(", ");
    }
    Console.WriteLine("]");
    Console.WriteLine($"Количество чётных чисел в массиве равно {count}");
}

int[] arr2 = CreateArrayRndInt(usersize, 100, 1000);
PrintArray(arr2);
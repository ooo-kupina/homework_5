// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Данная программа выведет одномерный массив, заполненный случайными целыми числами");
Console.WriteLine("в промежутке между -20 и 20, и покажет сумму элементов, стоящих на нечётных позициях (индексах).");
Console.Write("Введите размер массива - целое число от 1 до 30: ");
int usersize = Convert.ToInt32(Console.ReadLine());
int sum = 0;

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
        if (i % 2 != 0)
        {
            sum += array[i];
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
    Console.Write($"Сумма элементов, стоящих на нечётных позициях (индексах), равна {sum}");
}

int[] arr2 = CreateArrayRndInt(usersize, -20, 21);
PrintArray(arr2);
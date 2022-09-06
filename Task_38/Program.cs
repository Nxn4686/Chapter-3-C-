// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void FillArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

int[] arr = new int[6];
FillArray(arr);
Console.WriteLine("Программа создала массив: " + "[{0}]", String.Join(", ", arr));


int size = arr.Length;
int max = 0;
int min = arr[0];
for (int i = 0; i < size; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

Console.WriteLine("Максимальный элемент массива: " + max);
Console.WriteLine("Минимальный элемент массива: " + min);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + (max - min));

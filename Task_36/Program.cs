// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int length = arr.Length;
int result = 0;

for (int i = 1; i < length; i = i + 2)
{
    result = result + arr[i];
}

Console.WriteLine("Сумма нечетных чисел созданного массива равна: " + result);
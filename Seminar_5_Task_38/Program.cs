// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.Write("[" + string.Join(", ", array) + "]  -> ");
}


int MethodMin(int[] array)

{
    int i = 0;
    int min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int MethodMax(int[] array)
{
    int i = 0;
    int max = array[i];

    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}



FillArray(array);
int res = MethodMax(array) - MethodMin(array);
Console.WriteLine(res);



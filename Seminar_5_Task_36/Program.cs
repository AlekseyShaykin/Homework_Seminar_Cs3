// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 20);
        Console.Write($" {massiv[i]} ");
    }
}

int Method(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}


FillArray(array);
int sum = Method(array);
Console.WriteLine($" сумма чисел на нечетных позициях --> {sum}");

// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
        // Console.Write("[" + string.Join(", ", array) + "] --> ");
    }
    Console.Write("[" + string.Join(", ", arr) + "]");
}

// 

// void Method(int[] massiv)   - метод по поиску ВСЕХ четных чисел во всех элементах матрицы
// // {
//     int c = 0;
//     int mod1 = 0;
//     int mod2 = 0;
//     int mod3 = 0;

//     for (int index = 0; index < massiv.Length; index++)
//     {
//         mod1 = massiv[index] % 10;
//         mod2 = (massiv[index] / 10) % 10;
//         mod3 = massiv[index] / 100;

//         if (mod1 % 2 == 0 & mod1 != 0) c = c + 1;
//         if (mod2 % 2 == 0 & mod2 != 0) c += 1;
//         if (mod3 % 2 == 0 & mod3 != 0) c += 1;
//     }
//     Console.Write(" -> четных чисел "+c);
// }


void Method(int[] massiv)
{
    int c = new int();
    int mod1 = new int();
    // int mod2 = 0;
    // int mod3 = 0;

    for (int index = 0; index < massiv.Length; index++)
    {
        mod1 = massiv[index];
        // mod2 = (massiv[index] / 10) % 10;
        // mod3 = massiv[index] / 100;

        if (mod1 % 2 == 0) c += 1;
        // if (mod2 % 2 == 0 & mod2 != 0) c += 1;
        // if (mod3 % 2 == 0 & mod3 != 0) c += 1;
    }
    Console.Write(" -> четных чисел " + c);
}


PrintArray(array);
Method(array);

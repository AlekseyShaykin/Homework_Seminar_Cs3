// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Size()
{
    Console.Write("Сколько чисел будем вводить?  : ");
    int m = Int32.Parse(Console.ReadLine());
    return m;
}

int n = Size();
int[] array = new int[n];

void InputNumb(int m)
{
    Console.WriteLine("Input number");
    for (int i = 0; i < m; i++)
    {
        int n = Int32.Parse(Console.ReadLine());
        // int n = new Random().Next(1, 10);         
        array[i] = n;
        // Console.Write($" {array[i]} ");            если значения в массиве формируются рандомно, то консольку можно вызывать, находясь в цикле for
    }
    Console.Write("[ " + string.Join(", ", array) + " ] --> ");
}

InputNumb(n);

int Quantity(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

int res = Quantity(array);

Console.WriteLine(res);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumb(string N)
{
    Console.Write($"Input {N}: ");
    double n = Convert.ToDouble(Console.ReadLine());
    return n;
}

double b1 = InputNumb("b1");
double k1 = InputNumb("k1");
double b2 = InputNumb("b2");
double k2 = InputNumb("k2");

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

Intersection(b1, k1, b2, k2);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] new_array(int number) // функция задаёт массив с заданным кол-м случайных вещественных чисел.
{
    double[] array = new double[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * new Random().Next(1, 10); 
    }
    return array;
}
void PrintArr(double[] array) // функция просматривает массив вещественных часел.
{  
    foreach (double item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

void diminutionMaxAndMin(double[] array) // функция находит разницу между максимальным и минимальным элементом в массиве вещественных чисел.
{
    double min = 10000;
    double max = 0;
    double result = 0;
    foreach (double item in array)
    {
        if (item < min) min = item;
        if (item > max) max = item;
    } 
    result = max - min;
    Console.WriteLine($"Разницу между максимальным и минимальным элементом = {result}");  
}
//////////////

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
double[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
PrintArr(arr);
diminutionMaxAndMin(arr);

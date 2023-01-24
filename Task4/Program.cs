// 1) Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

int[] new_array(int number) // функция задаёт массив с заданным кол-м случайных значений.
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(20, 26); 
    }
    return array;
}
void PrintArr(int[] array) // функция просматривает массив целых часел.
{  
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[] replace20to200(int[] array) // функция показывает сумму чисел одномерного массива стоящих на нечетной позиции.
{    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 20) 
        {
            array[i] = 200;
            break;
        }
    }
    return array;
}
//////////////

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
PrintArr(arr);
int[] new_arr = replace20to200(arr);
Console.WriteLine("Посмотрим новый массив:");
PrintArr(new_arr);

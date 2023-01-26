// N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно. Определите, какие кегли остались стоять на месте.
// Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при этом 1≤ li≤ ri≤ N.
// Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять, или “.”, если j-я кегля была сбита.

string[] new_array(int number) // функция задаёт массив с заданным кол-м кеглей.
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = "I"; 
    }
    return array;
}
void PrintArr(string[] array) // функция просматривает массив кеглей.
{  
    foreach (string item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
string[] bowlsOff(string[] array, int number) // Функция считает какие кегли были сбиты.
{
    for (int i = 0; i < number; i++)
    {
        int l = new Random().Next(1, array.Length + 1);
        int r = new Random().Next(l, array.Length + 1);
        Console.WriteLine(l + " " + r);
        for (int j = l - 1; j < r; j++) {array[j] = ".";}
    }
    return array;
}

Console.Write("Укажите число кеглей: ");
int n = int.Parse(Console.ReadLine() ?? "0");
string[] arr = new_array(n);
PrintArr(arr);
Console.Write("Укажите число бросков: ");
int k = int.Parse(Console.ReadLine() ?? "0");
bowlsOff(arr, k);
PrintArr(arr);

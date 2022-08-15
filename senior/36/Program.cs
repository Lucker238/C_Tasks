//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

string showArray(int[] arr)
{
    return string.Join(", ", arr);
}

int[] makeArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] showEvOd(int[] arr)
{
    int[] result = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result[1]++;
        else result[0]++;
    }
    return result;
}

System.Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = makeArray(length);
int[] evenOdd = showEvOd(array);

System.Console.WriteLine(showArray(array));
System.Console.WriteLine($"Количество четных чисел равно: {evenOdd[1]}");
System.Console.WriteLine($"Количество нечетных чисел равно: {evenOdd[0]}");

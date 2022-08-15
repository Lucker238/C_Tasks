// Написать программу замену элементов массива на противоположные

string showArray(int[] arr)
{
    return string.Join(", ", arr);
}

int[] makeArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] turnArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i <= (result.Length/2); i++)
    {
        int first = arr[i];
        int last = arr[arr.Length-1-i];
        result[i] = last;
        result[arr.Length-1-i] = first;
    }
    return result;
}

System.Console.Write("Введите длинну массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = makeArray(N);

System.Console.WriteLine(showArray(array));
System.Console.WriteLine(showArray(turnArray(array)));
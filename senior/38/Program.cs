//Найти сумму чисел одномерного массива стоящих на нечетной позиции

string showArray(int[] arr)
{
    return string.Join(", ", arr);
}

int[] makeArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int findSum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i += 2) sum += arr[i];
    return sum;
}

System.Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = makeArray(length);

System.Console.WriteLine(showArray(array));
System.Console.WriteLine(findSum(array));

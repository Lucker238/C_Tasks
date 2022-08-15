// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

string showArray(int[] arr)
{
    return string.Join(", ", arr);
}

int[] makeArray()
{
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

int findNumbers(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99) count++;
    }
    return count;
}

int[] longArray = makeArray();

System.Console.WriteLine(showArray(longArray));
System.Console.WriteLine(findNumbers(longArray));

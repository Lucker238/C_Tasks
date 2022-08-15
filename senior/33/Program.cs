//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

string showArray(int[] arr)
{
    return string.Join(", ", arr);
}

int[] makeArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
int[] findSum(int[] array)
{
    int[] result = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result[1] += array[i];
        else result[0] += array[i];
    } 
    return result;
}

int[] array = makeArray();

System.Console.WriteLine(showArray(array));
System.Console.WriteLine(showArray(findSum(array)));
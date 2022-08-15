//Определить, присутствует ли в заданном массиве, некоторое число 

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

bool isNumberExist(int[] arr, int num)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
}

System.Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число для поиска в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = makeArray(length);


System.Console.WriteLine(showArray(array));
System.Console.WriteLine(N);
System.Console.WriteLine(isNumberExist(array, N));

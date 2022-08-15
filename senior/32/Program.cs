// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

string showArray(int[] arr)
{
    return string.Join(", ", arr);
}

int[] makeArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}


System.Console.WriteLine(showArray(makeArray()));
// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void findMulti(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length/2; i++)
    {
        int mult = arr[i] * arr[length - 1 - i];
        System.Console.WriteLine($"Произведение пары {arr[i]} и {arr[length-1-i]} равно: {mult}");
    }
    if(length % 2 != 0)
    {
        System.Console.WriteLine($"Элемент {arr[length/2]} не имеет пары");
    }
}

System.Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = makeArray(length);
System.Console.WriteLine(showArray(array));
findMulti(array);

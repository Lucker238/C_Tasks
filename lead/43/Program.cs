// Написать программу преобразования десятичного числа в двоичное

int[] binNumber(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
       result[i] = new Random().Next(0,2); 
    }
    return result;
}

int toDecimal(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        result += array[i] * (int)Math.Pow(2, array.Length - 1 - i);
    }
    return result;
}

System.Console.Write("Введите длину двухмерного массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = binNumber(N);
System.Console.WriteLine(string.Join(",", array));
System.Console.WriteLine(toDecimal(array));
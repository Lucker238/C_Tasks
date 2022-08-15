// Написать программу вычисления произведения чисел от 1 до N

long findMult(int num)
{
    long mult = 1;
    for(int i = 1; i <= num; i++)
    {
        mult *= Convert.ToInt64(i);
    }
    return mult;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findMult(N));
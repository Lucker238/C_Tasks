// Подсчитать сумму цифр в числе

int findNumbersSum(long N)
{
    long sum = 0;
    while(N > 0)
    {
        sum += N % 10;
        N /= 10;
    }
    return Convert.ToInt32(sum);
}

System.Console.Write("Введите число: ");
long A = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine(findNumbersSum(A));
// Определить количество цифр в числе

int findNumbersQ(long N)
{
    int count = 0;
    while(N > 0)
    {
        N /= 10;
        count++;
    }
    return count;
}
System.Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine(findNumbersQ(number));
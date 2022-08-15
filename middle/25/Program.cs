//Найти сумму чисел от 1 до А

int findSum(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findSum(A));

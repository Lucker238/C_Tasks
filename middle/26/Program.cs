//Возведите число А в натуральную степень B используя цикл

int findSquare(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

System.Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findSquare(A, B));
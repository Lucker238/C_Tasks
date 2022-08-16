// Показать числа Фибоначчи

int[] fibonachi(int num)
{
    if(num == 1) 
    {
        int[] check = {0};
        return check;
    }
    int[] fibonach = new int[num];
    fibonach[0] = 0;
    fibonach[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonach[i] = fibonach[i - 1] + fibonach[i - 2];
    }
    return fibonach;
}
System.Console.Write("Введите количество чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(string.Join(", ", fibonachi(N)));
//Показать таблицу квадратов чисел от 1 до N 

void squareTable(int num)
{
    for(int i = 1; i <= num; i++)
    {
       System.Console.WriteLine($"{i} * {i} = {i*i}"); 
    }
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

squareTable(N);
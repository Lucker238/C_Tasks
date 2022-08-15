//Найти кубы чисел от 1 до N

void cubeTable(int num)
{
    for(int i = 1; i <= num; i++)
    {
       System.Console.WriteLine($"{i} ^ {3} = {i*i*i}"); 
    }
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

cubeTable(N);
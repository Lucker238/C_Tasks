//Показать кубы чисел, заканчивающихся на четную цифру

void bigCubeTable(int num)
{
    for(int i = 1; i <= num; i++)
    {
        if((i % 10) % 2 == 0)
        {
            System.Console.WriteLine($"{i} ^ {3} = {i*i*i}"); 
        }
    }
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

bigCubeTable(N);


// Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```

double[] strToDoubleArray(string input)
{
    input = input.Replace(" ", ",");
    input = input.Replace("(", ",");
    input = input.Replace(")", ",");
    string[] array = input.Split(",");
    double[] numArray = new double[8];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != "")
        {
            numArray[j] = Convert.ToDouble(array[i]);
            j++;
        }
    }
    return numArray;
}


double[] scale(double[] input, double mult)
{
    double[] result = new double[input.Length];
    result[0] = input[0];
    result[1] = input[1];
    for (int i = 2; i < input.Length; i++)
    {
        if (i % 2 == 0)
        {
            result[i] = (input[i] - result[0]) * mult;
        }
        else
        {
            result[i] = (input[i] - result[1]) * mult;
        }
    }
    return result;
}


string makeOutput(double[] sqaled)
{
    string output = "(";
    for (int i = 0; i < sqaled.Length; i++)
    {
        if (i % 2 == 0)
        {
            output += Convert.ToString(sqaled[i]);
            output += " , ";
        }
        else
        {
            output += Convert.ToString(sqaled[i]);
            output += ") (";
        }
    }
    output = output.Remove(output.Length - 2);

    return output;
}


System.Console.Write("Введите вершины фигуры в формате (x,y): ");
double[] input = strToDoubleArray(Console.ReadLine());
System.Console.Write("Введите коэффициент масштабирования: ");
double K = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(makeOutput(scale(input, K)));


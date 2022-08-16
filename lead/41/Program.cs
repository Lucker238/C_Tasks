// Выяснить являются ли три числа сторонами треугольника 

string isTriangle(double a, double b, double c)
{
    if(a + b > c && a + c > b && b + c > a) return "Это треугольник";
    else return "Это не треугольник";
}

System.Console.Write("Введите первую сторону: ");
double A = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите вторую сторону: ");
double B = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите третью сторону: ");
double C = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(isTriangle(A, B, C));
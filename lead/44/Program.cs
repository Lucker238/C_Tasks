﻿//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double[] crossPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    if (k1 == k2)
    {
        point[0] = -99999;
        point[1] = -99999;
    }
    else
    {
        point[0] = (b2 - b1) / (k1 - k2);
        point[1] = point[0] * k1 + b1;
    }
    return point;
}

string checkParal(double[] array)
{
    if(array[0] == -99999 && array[1] == -99999) return "Прямые параллельны";
    else return string.Join(", ", array);
}


System.Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(checkParal(crossPoint(b1, k1, b2, k2)));
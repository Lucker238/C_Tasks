// Написать программу копирования массива

int[] newMassiv(int[] input)
{
    int[] output = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        output[i] = input[i];
    } 
    return output;
}


int[] input = {1, 2, 3, 4, 5, 6, 7, 8, 9, 2000};
System.Console.WriteLine(string.Join(", ", newMassiv(input)));
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
double[,] InputArray(int m, int n)
{
    double[,] result = new double[m,n];
    var rnd = new Random();
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j]=Math.Round(rnd.NextDouble(),2);
        }
    }  

    return result;
}

void PrintArray(double[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1); 
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }  
}

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(InputArray(m,n));
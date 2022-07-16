//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
int[,] InputArray(int m, int n)
{
    int[,] result = new int[m,n];
    var rnd = new Random();
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j]=rnd.Next(1,100);
        }
    }  

    return result;
}

void PrintArray(int[,] array)
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

void ArithmeticMean(int[,]array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);    
    for(int j=0;j<cols;j++)
    {
        int sum = 0;
        for(int i=0;i<rows;i++)
        {
            sum = sum + array[i,j];
        }
        double arithmeticMean = Math.Round(Convert.ToDouble(sum)/Convert.ToDouble(rows),2);
        if(j==cols-1) Console.Write(arithmeticMean);
        else Console.Write(arithmeticMean + "; ");
    }
}

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array = InputArray(m,n);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
ArithmeticMean(array);

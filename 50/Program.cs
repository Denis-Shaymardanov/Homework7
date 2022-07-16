//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет
void PrintElement(int[,]array, int m, int n)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    if (m>rows||n>cols) Console.WriteLine("Такого элемента в массиве нет");
    else Console.WriteLine(array[m,n]);
}
int[,] array = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
PrintElement(array, m,n);

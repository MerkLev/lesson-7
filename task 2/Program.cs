Console.WriteLine("Задайте размер массива");
Console.WriteLine("Введите количество строк");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns=Convert.ToInt32(Console.ReadLine());

int [,] GetMatrix(int M,int N)
{
    int  [,] Array= new int [M,N];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int k = 0; k < N; k++)
        {
            Array[i,k]= new Random().Next(10);
        }
    }
    return Array;
}
void PrintMatrix(int[,]inputMatrix)
{
     for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int M = 0; M < inputMatrix.GetLength(1); M++)
        {
            Console.Write(inputMatrix[i,M] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetMatrix(rows,columns);
Console.WriteLine("Массив : ");
PrintMatrix(resultMatrix);
Console.Write("Выберите элемент формата O.O: ");
int NumberRows=Convert.ToInt32(Console.ReadLine());
int NumberColumns=Convert.ToInt32(Console.ReadLine());

if(NumberRows>=resultMatrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else if (NumberColumns>=resultMatrix.GetLength(0))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine(resultMatrix[NumberRows,NumberColumns]);
}
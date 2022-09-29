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
double [] Array= new double [resultMatrix.GetLength(0)];

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    double sum=0;
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        sum=sum+resultMatrix[j,i];
    }
    Array[i]=((Math.Round (sum/resultMatrix.GetLength(0),2)));
}
double Aver=resultMatrix.GetLength(0);

double [] AverageArray= Array;
Console.WriteLine(string.Join(" ",  AverageArray));
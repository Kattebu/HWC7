// Задача 47: Задать двумерный массив размером m*n случайными вещественными числами
double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows,cols];//[строчка, столбец]
    for(int i =0; i<matrix.GetLength(0); i++)//строчки rows=matrix.GetLength(0)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().NextDouble();
        }
    }
    return matrix;//вернули заполненную таблицу
}
//метод для печати матрицы (двумерного массива)
void PrintMatrix(double[,] matr)
{
for(int i =0; i<matr.GetLength(0); i++)//строчки rows=matrix.GetLength(0) проход по строчкам
    {
        for (int m =0; m<matr.GetLength(1); m++)//проход по столбцам
        {
            Console.Write(matr[i,m]+"\t");//4 пробела таб
        }
        Console.WriteLine();//для того чтобы были строчки
    }
}
double[,] resultMatrix=GetMatrix(5,4);//3 строчки, 4 столбца, числа от 0 до 10
PrintMatrix(resultMatrix);
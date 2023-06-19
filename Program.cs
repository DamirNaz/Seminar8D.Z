//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите колличество строк:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов:");
// int columns=Convert.ToInt32(Console.ReadLine());
// int [,]array=new int[rows,columns];
// void GetArray()
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             {
//                 array[i,j]=new Random ().Next (0,10);
//             }
//     }
// }
// void PrintArray()
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             {
//                 Console.Write(array[i,j]+" ");
//             }
//             Console.WriteLine();
//     }
// }
// void SortArray()
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1) -1;j++)
//             {
//                 for (int z=0;z<array.GetLength(1) -1;z++)
//                 {
//                     if(array[i,z]<array[i,z+1])
//                 {
//                     int temp=array[i,z];
//                     array[i,z]=array[i,z +1];
//                     array[i,z +1]=temp;
                    
//                 }
                
//             }
//             }    
//     }
// }

// GetArray();
// PrintArray();
// Console.WriteLine();
// SortArray();
// PrintArray();

//____________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

// int [,]array=new int[4,5];
// void GetPrintArray()
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             {
//                 array[i,j]=new Random ().Next (0,10);
//                 Console.Write(array[i,j]+" ");
//             }
//             Console.WriteLine();
//     }
// }
// void CountSum()
// {
//     int minsum=Int32.MaxValue;
//     int minindex=0;
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         int sum=0;  
//         for (int j=0;j<array.GetLength(1);j++)
//             {
//                 sum=array[i,j] +sum;  
//             }
//             if(sum<minsum)
//             {
//                 minsum=sum;
//                 minindex=i;
//             }
//     }
//     Console.WriteLine("строка с наименьшей суммой элементов:" +(minindex+1)); 
// }
// GetPrintArray();
// CountSum();

//_____________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,]array1=new int[2,2];
// int [,]array2=new int[2,2];

// void GetArray(int[,]array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             {
//                 array[i,j]=new Random ().Next (0,10);
//             }
//     }
// }
// void PrintArray(int[,]array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// int [,]array3=new int[2,2];
// void ResultArray()
// {
//     for (int i=0;i<array3.GetLength(0);i++)
//     {
//         for (int j=0;j<array3.GetLength(1);j++)
//         {
//             int sum=0;
//             for (int k=0;k<array3.GetLength(1);k++)
//             {
//                 sum+=array1[i,k]*array2[k,j];
//             }
//             Console.Write((array3[i,j]=sum)+" ");
//         }
//         Console.WriteLine();
//     }
// }

// GetArray(array1);
// PrintArray(array1);
// Console.WriteLine();
// GetArray(array2);
// PrintArray(array2);
// Console.WriteLine("Результирующая матрица будет:");
// ResultArray();

//____________________________________________________________________________

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int [,,]array=new int[2,2,2];
// void FillArray(int[,,]result)
// {
//     int count=10;
//     for (int i=0;i<result.GetLength(0);i++)
//     {
//         for (int j=0;j<result.GetLength(1);j++)
//         {
//             for (int k=0;k<result.GetLength(2);k++)
//             {
//                 result[i,j,k]+=count;
//                 count+=5;
//             }
//         }
//     }
// }
// void PrintArray(int[,,]result)
// {
//     for (int i=0;i<result.GetLength(0);i++)
//     {
//         for (int j=0;j<result.GetLength(1);j++)
//         {
//             Console.WriteLine();
//             for (int k=0;k<result.GetLength(2);k++)
//             {
//                 Console.Write(array[i,j,k]+" "+(i,j,k));
//             }
//         }
//     }
// }
// FillArray(array);
// PrintArray(array);

//___________________________________________________________________

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,]array=new int[4,4];
int count=0;
int i=0;
int j=0;
for (j=0;j<array.GetLength(1);j++)
{
    array[i,j]=count+1;          //заполнение строки с индексом 0
    count++;
}
j=3;    //заполнение столбца с индексом 3
for (i=0;i<array.GetLength(0);i++)
{
    array[i,j]=1+count;
    count++;
}
i=3;
for (j=2;j>=0;j-=1)
{
    array[i,j]=1+count;
    count++;
}
j=0;
for (i=2;i>=1;i-=1)
{
    array[i,j]=count+1;
    count++;
}
i=1;
for (j=1;j<=2;j++)
{
    array[i,j]=count+1;
    count++;
}
i=2;
for (j=2;j>=1;j-=1)
{
    array[i,j]=count+1;
    count++;
}
for (i=0;i<array.GetLength(0);i++)
{
    for (j=0;j<array.GetLength(1);j++)
    {
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
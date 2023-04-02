// 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.WriteLine("Введите число:"); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число:"); 
// int columns = Convert.ToInt32(Console.ReadLine());  
// int [,] array = new int [rows,columns];  
// for (int i = 0; i < array.GetLength(0); i++) 
// {    
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {       
//         array[i,j]=new Random().Next(0,10);       
//         Console.Write(array[i,j]+" ");    
//     }    
// Console.WriteLine(); 
// }
// Console.WriteLine("Отсортиванный массив");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < (array.GetLength(1)-1); k++)
//         {
//             if (array[i, k] < array[i, k + 1])
//             {
//                 int temp = array[i, k + 1];
//                 array[i, k + 1] = array[i, k];
//                 array[i, k] = temp;
                
//             } 
//         }
//     }
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+" ");
//     }
// Console.WriteLine();
// }
//56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Введите число:"); 
// int rows = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число:"); 
//  int columns = Convert.ToInt32(Console.ReadLine());  
//  int [,] array = new int [rows,columns];  
//  for (int i = 0; i < array.GetLength(0); i++) 
//  {    
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {       
//         array[i,j]=new Random().Next(0,10);      
//         Console.Write(array[i,j]+" ");    
//     }    
// Console.WriteLine(); 
// }
// int [] arrysum = new int [rows];
// int minsum=0;
// int minnum=0;
// for (int i = 0; i < array.GetLength(0); i++) 
//  {   
//     arrysum[i]=0; 
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {       
//        arrysum[i]=arrysum[i]+array[i,j];
//     } 
//     if (i==0)
//     {
//         minsum=arrysum[i];
//         minnum=i+1;
//     }  
//     else
//     {
//         if (arrysum[i]<minsum)
//         {
//             minsum=arrysum[i];
//             minnum=i+1;
//         }

//     }
// }
// Console.WriteLine($"Минимальная сумма {minsum} в строке {minnum}");


//58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int rows =2;
// int columns =2;
// int [,] array1 = new int [rows,columns]; 
// int [,] array2 = new int [rows,columns]; 
// for (int i= 0; i< array1.GetLength(0); i++)
// {
//     for (int j= 0; j < array1.GetLength(1); j++)
//     {
//         array1[i,j]=new Random().Next(0,10);
//         Console.Write(array1[i,j] + " ");
//     }
// Console.Write(" | ");
// for (int j = 0; j < array2.GetLength(1); j++)
//     {
//        array2[i,j]=new Random().Next(0,10);
//        Console.Write(array2[i,j] + " ");
//     }
// Console.WriteLine();
// }

// int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
 
// for (int i = 0; i < array1.GetLength(0); ++i)
// {
//     for (int j = 0; j < array2.GetLength(1); ++j)
//         {
//             for (int k = 0; k < array2.GetLength(1); ++k)
//                 {
//                     array3[i, j] += array1[i, k] * array2[k, j];
//                 }
//         Console.Write(array3[i,j] + " ");
//         }
//     Console.WriteLine();
// }
 // 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
 //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2  
// int x = 2;
// int y = 2;
// int z = 2;
// int[,,] array = new int[x, y, z];
// for (int i = 0; i< array.GetLength(0); i++)
//   {
//     for (int j= 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         array[i, j, k] = new Random().Next(0,100);
//         Console.Write($"{array[i,j,k]} ({i},{j},{k}), ");
//       }
//       Console.WriteLine();
//     }
//   }

//47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите число:"); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число:"); 
// int columns = Convert.ToInt32(Console.ReadLine());  
// double [,] array = new double [rows,columns]; 
// Random rand =new Random(); 
// for (int i = 0; i < array.GetLength(0); i++) 
// {    
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {   
//         array[i,j]=Math.Round(rand.Next(-100, 101)*0.1, 1);
//         Console.Write(array[i,j]+" ");    
//     }    
// Console.WriteLine(); 
// }
//50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.WriteLine("Введите число:"); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число:");
// int columns = Convert.ToInt32(Console.ReadLine()); 
// int [,] array = new int [rows,columns];  
// for (int i = 0; i < array.GetLength(0); i++)
// {    
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {      
//          array[i,j]=new Random().Next(0,10);      
//           Console.Write(array[i,j]+" ");    
//     }    
// Console.WriteLine(); 
// }
// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// bool isExist = false;
// for (int i = 0; i < array.GetLength(0); i++)
// {    
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {      
//          if (array[i,j]==A)
//          {
//             isExist=true;
//             Console.WriteLine("Число присутсвует в массиве");
//             break;
//          }
        
//     }
//     if (isExist==true)
//         {
//             break;
//         }   
// }
//  if (isExist==false)
//  {
//   Console.WriteLine("Такого числа нет");
//  }

// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("Введите число:"); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число:"); 
// int columns = Convert.ToInt32(Console.ReadLine()); 
// double a = 0.0;
//  int [,] array = new int [rows,columns];  
//  for (int i = 0; i < array.GetLength(0); i++)
//   {    
//     for (int j = 0; j < array.GetLength(1); j++)    
//     {       
//         array[i,j]=new Random().Next(0,10);       
//         Console.Write(array[i,j]+" ");   
//     }    
// Console.WriteLine(); 
//   }
//   for (int j = 0; j < array.GetLength(1); j++)
//   {    
//     for (int i = 0; i< array.GetLength(0); i++)    
//     {       
//         a=a+array[i,j];
//     }   
// a=a/array.GetLength(0);
// Console.WriteLine($"Cреднее {a}");
// a = 0.0;
//   }
// 64 Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.WriteLine("Введите число");
// double num =int.Parse(Console.ReadLine()); 
// double count = 0.5;  
// double PrintNumber()
// {   
//     if(count>num)   
//     {     
//         return count;  
//     }     
// Console.Write(count+" ");    
// count+=0.5;    
// return (PrintNumber()); 
// }  
// PrintNumber();
// 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите число M"); 
// int M =int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите число N"); 
// int N =int.Parse(Console.ReadLine()); 
// int count=0;  
// int stop_count=0;
// int sum = 0;
// if (N>M)
// {
//   count=M;
//   stop_count=N;
// }
// else
// {
//     count=N;
//     stop_count=M;
// }
// int PrintNumber() 
// {   
//     if(count>stop_count)  
//  {    
//      return count;   
// }    
//  Console.Write(count+" ");    
 
// sum = sum+count;
//  count++;  
//  return (PrintNumber()); 
//  }  
//  PrintNumber();
// Console.WriteLine();
// Console.Write($"Cумма {sum}");
// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// Console.WriteLine("Введите число M"); 
// int M =int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите число N"); 
// int N =int.Parse(Console.ReadLine()); 

// int AckermannFunction (int M, int N)
// {
//     if (M == 0) return N + 1;
//     if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
//     if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
// return AckermannFunction(M, N);
// }

// Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");

//Задача 23 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Write("Введитe число"); 
// int num = Convert.ToInt32(Console.ReadLine()); 
// int i = 1; 
//  while (i<=num) 
//  {    
//      Console.Write(Math.Pow(i,3) +"  ");   
//        ++i;
//  }

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.Write("Введи X точки B"); 
// int XB = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введи Y точки B"); 
// int YB = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введи Z точки B"); 
// int ZB = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введи X точки A"); 
// int XA = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введи Y точки A"); 
// int YA = Convert.ToInt32(Console.ReadLine());   

// Console.Write("Введи Z точки A"); 
// int ZA = Convert.ToInt32(Console.ReadLine()); 

// double number =Math.Sqrt((Math.Pow ((XB-XA),2))+(Math.Pow ((YB-YA),2)+(Math.Pow ((ZB-ZA),2))));  
  
// Console.Write(number);

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.Write("Введитe число"); 
// string anyNumber=Console.ReadLine();
// int l =anyNumber.Length;

// if (l == 5)
// {
//     if (anyNumber.Substring(0,1) == anyNumber.Substring(4,1) && anyNumber.Substring(1,1) == anyNumber.Substring(3,1))
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }
// else
// {
//     Console.WriteLine("не подходит под условие задачи");
// }
// 34.Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//
// int[] arry = new int[4];
// int a = 0;
// for (int i = 0; i <arry.Length; i++)
// {
//     arry[i]=new Random().Next(100,1000);
//     if (arry[i]%2==0)
//     {
//         a++;
//     }
// }
// Console.WriteLine(String.Join(",",arry));
// Console.WriteLine($"Количество четных чисел {a}");
//36.Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// int [] arry = new int[4];
// int sum =0;
// for (int i = 0; i < arry.Length; i++)
// {
//     arry[i]=new Random().Next (0,11);
//     if (i%2>0)
//     {
//         sum = sum + arry[i];
//     }
// }
// Console.WriteLine(String.Join(",",arry));
// Console.Write($"Cумма нечетных элементов {sum}");
//38.Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// int [] arry = new int[4];

// for (int i = 0; i < arry.Length; i++)
// {
//   arry[i]=new Random().Next (0,11);  
// }
// int dif= arry.Max()-arry.Min();
// Console.WriteLine(String.Join(",",arry));
// Console.Write($"Разница между максимальным и минимальным элементом массива {dif}");

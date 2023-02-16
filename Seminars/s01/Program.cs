// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA > numB) Console.WriteLine($"Число {numA} больше. Число {numB} меньше.");
// else Console.WriteLine($"Число {numB} больше. Число {numA} меньше.");
// ---------------------------------
// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > a) max = b; 
// if (c > b) max = c;
// Console.WriteLine($"Максимальное из введенных вами чисел: {max}");
// ---------------------------
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2 == 0) 
// {
//     Console.WriteLine("Число является четным");
// }
// else 
// {
//     Console.WriteLine("Число не является четным");
// }
// ---------------------
// Console.Clear();
// Console.WriteLine("Введите натуральное число: ");
// int a = Convert.ToInt32(Console.ReadLine());


// int x =1;
// if (a > 0)
// {
//     Console.WriteLine($"Четные числа от 1 до {a}: ");
//     while (x < a)

//     {
//         Console.Write(x+1+" ");
//         x+=2;
//     }
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не натуральное число. Введите НАТУРАЛЬНОЕ число!");
// }

// int index = 2;

// if (numN >= index);
// while (index < numN)
// {
//     Console.Write(index);
//     index=index+2;
// }
// // else
// // {
// //     System.Console.WriteLine("Число не соответствует условию задачи. Введите НАТУРАЛЬНОЕ число.");
// }    
// ------------лекция 2 задача 1-------------

// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10, 100);
// Console.WriteLine($"случайное число из отрезка 10 - 99 --> {num}");
// int firstDigit = num / 10;
// int secondDigit = num % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

// ------------лекция 2 задача 2------------ -

// int num = new Random().Next(10, 100);
// Console.WriteLine($"случайное число из отрезка 10 - 99 --> {num}");

// //      Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// // else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

// int maxDigit = MaxDigit(num);
// Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
// // 
// int MaxDigit(int numb)//получить, вернуть
// {
//     int firstDigit = numb / 10;
//     int secondDigit = numb % 10;
//     if (firstDigit > secondDigit) return firstDigit;
//     return secondDigit; //возвращающая функция
// }

// ------------лекция 2 задача 3------------ -

// int num = new Random().Next(10, 100);
// Console.WriteLine($"случайное число из отрезка 10 - 99 --> {num}");

// //      Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// // else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

// int maxDigit = MaxDigit(num);
// Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
// // 
// int MaxDigit(int numb)//получить, вернуть
// {
//     int firstDigit = numb / 10;
//     int secondDigit = numb % 10;
//     // // if (firstDigit > secondDigit) return firstDigit;
//     // // return secondDigit; //возвращающая функция
//     // int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//     // return result;
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
   
// }
// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999 --> {num}");
// int firstDigit = num / 100;
// int secondDigit = num % 10;
// Console.WriteLine($"Первая и последняя цифра числа {num} будет: {firstDigit}{secondDigit}");

// int maxD = MaxD(num);
// Console.WriteLine($"Первая и последняя цифра = {maxD}");

// int MaxD (int numm)
// {
//     int firstDigit = numm / 100;
//     int thirdDigit = numm % 10;
//     int result = firstDigit * 10 + thirdDigit;
//     return result;
// }

// ------------лекция 2 задача 4------------ -

// // 12. Напишите программу, которая будет принимать на
// // вход два числа и выводить, является ли первое число
// // кратным второму. Если число 1 не кратно числу 2, то
// // программа выводит остаток от деления.
// // 34, 5 -> не кратно, остаток 4
// // 16, 4 -> кратно
// Console.Clear();
// System.Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// // int res = numA % numB;
// // if (res == 0) Console.WriteLine($"кратно");
// // else Console.WriteLine($"не кратно {res}");

// int res = Met(numA, numB);

// int Met (int num1, int num2)
// {
//     return num1 % num2;
// }
// {
//     if (numA % numB == 0)
//     {
//         System.Console.WriteLine($"Введенное число кратно {numA}{numB}");
//     }
// }
// ПРАВИЛЬНОЕ РЕШЕНИЕ------------------
// Console.WriteLine("Введите первое число: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// int result = Multiplicity(numberOne, numberTwo);

// if (result == 0) Console.WriteLine("Кратно");
// else Console.WriteLine("не кратно, остаток : " + result);

// int Multiplicity(int num1, int num2)
// {
// 	return num1 % num2;
// }

// ------------лекция 2 задача 5 и 6------------ -

// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
// Console.WriteLine("Введи число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = 7;
// int num2 = 23;
// if (num % num1 == 0 && num % num2 == 0)
//     {
//         Console.WriteLine($"Введенное число {num} кратно {num1} и {num2}");
//     }
//     else System.Console.WriteLine($"Введенное число {num} НЕ КРАТНО {num1} и {num2}");

// // -------------------ВЕРНОЕ РЕШЕНИИЕ с МЕТОДОМ
// Console.WriteLine("Введи число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = 7;
// int num2 = 23;

// if (Mult(num, num1, num2))
// Console.WriteLine($"Введенное число {num} кратно {num1} и {num2}");
// else System.Console.WriteLine($"Введенное число {num} НЕ КРАТНО {num1} и {num2}");

// bool Mult (int number, int number1, int number2)
// {
//     return number % 7 == 0 && number % 23 == 0;
//         // return num % num1 == 0 && num % num2 == 0;
// }
// -------------------ЗАДАЧА 5

// Console.WriteLine("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b * b || b == a * a) Console.WriteLine($"{a}, квадрат {b}");
// else Console.WriteLine($"{a}, не квадрат {b}");
// ----------Задача но не оптимальная
/* 16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

//Блок МЕТОДА 

// bool Squar(int number1, int number2)
// {
//     return number1 / number2 == number2 || number2 / number1 == number1;
//  }

// //Тело программы

// Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (Squar(num1, num2)) Console.WriteLine("да");
// else Console.WriteLine("нет");

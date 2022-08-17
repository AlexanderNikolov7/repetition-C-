// 1 Вывести квадрат числа.

// int num = new Random().Next(0,10);
// double res = Math.Pow(num, 2);
// Console.Write(res);

// 2 По двум заданным числам проверять является ли первое квадратом второго.
// Console.Write("Введите превое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());
// if (a == b*2) Console.Write("первое число является квадратом второго");
// else Console.Write("первое число не является квадратом второго");

// 3 Даны два числа. Показать большее и меньшее число.

// int a = new Random().Next(1, 10);
// int b = new Random().Next(1, 10);
// if (a > b) Console.Write($"{"число"} {a} {"больше, чем число"} {b}");
// if (a == b) Console.Write($"{"число"} {a} {"равно числу"} {b}");
// if (a < b) Console.Write($"{"число"} {b} {"больше, чем число"} {a}");

// 4 По заданному номеру дня недели вывести его название.

// Console.Write("введите номер дня недели: ");
// int num = int.Parse(Console.ReadLine());
// if (num == 1) Console.Write("Пн");
// if (num == 2) Console.Write("Вт");
// if (num == 3) Console.Write("Ср");
// if (num == 4) Console.Write("Чт");
// if (num == 5) Console.Write("Пт");
// if (num == 6) Console.Write("Сб");
// if (num == 7) Console.Write("Вс");

// 5 Найти максимальное из трех чисел

// int a = new Random().Next(1, 10);
// int b = new Random().Next(1, 10);
// int c = new Random().Next(1, 10);
// Console.Write($"{a} , {b} , {c}: ");
// int max = a; 
// if (max < b) max = b;
// if (max < c) max = c;
// Console.Write($"максимальное из трех чисел = {max}");

// 6 Написать программу вычисления значения функции y = f(a); f(a) = a^2 - 5

// Console.Write("введите значение a: ");
// int a = int.Parse(Console.ReadLine());
// // int y = a * a - 5;
// System.Console.WriteLine($"y = f(a) = {a * a - 5}");

// 7 Выяснить является ли число чётным.

// int num = new Random().Next(0,100);
// if (num % 2 == 0) Console.Write($"число {num} чётное");
// else Console.WriteLine($"число {num} не чётное");

// 8 Показать числа от -N до N.

// Console.Write("введите значение N: ");
// int N = int.Parse(Console.ReadLine());
// int count = N * -1;
// while (count <= N)
// {
//     Console.Write($"{count} ");
//     count++;
// }

// 9 Показать четные числа от 1 до N.

// Console.Write("введите значение N: ");
// int N = int.Parse(Console.ReadLine());
// int count = 1;
// while (count <= N)
// {
//     if (count % 2 == 0) Console.Write($"{count} ");
//     count++;
// }

// 10 Показать последнюю цифру трёхзначного числа.

// Console.Write("введите трёззначное число: ");
// string num = Console.ReadLine();
// if (num.Length == 3)
// {
//     Console.WriteLine(num[2]);
// }
// else System.Console.WriteLine("это не трёхзначное число!");

// 11 Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

//  1 способ - решаем при помощи массива
// int[] array = new int[2];
// int number = new Random().Next(10, 100);
// Console.WriteLine(number);
// for (int i = array.Length - 1; i >= 0; i--)
// {
//     array[i] = number % 10;
//     number /= 10;
// }
// if (array[0] > array[1]) Console.WriteLine(array[0]);
// else Console.WriteLine(array[1]);

//  2 способ - решаем при помощи строки
// int num = new Random().Next(10, 100);
// Console.WriteLine(num);
// string str = string.Empty;
// while (num > 0)
// {
//    str = (num % 10) + str;  //поставить последнюю цифру и поместить ее в начало строки
//    num = num /10;  //убрать последнюю цифру
// }
// if (str[0] > str[1]) Console.WriteLine(str[0]);
// else Console.WriteLine(str[1]);

// 12. Удалить вторую цифру трёхзначного числа.

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// string str = string.Empty;
// while (num > 0)
// {
//     str = (num % 10) + str;  //поставить последнюю цифру и поместить ее в начало строки
//     num = num / 10;  //убрать последнюю цифру
// }
// string str1 = string.Empty;
// for (int i = 0; i < str.Length; i++)
// {
//     if (i != 1) str1 = str1 + str[i];
// }
// Console.WriteLine(str1);

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.Write("введите число: ");
// int number = int.Parse(Console.ReadLine());
// int num = 1000;
// if (num % number == 0) System.Console.WriteLine($"Число 1000 кртно числу {number}");
// else Console.WriteLine($"Число 1000 не кртно числу {number} и остаток равен {num % number}");

// 14. Найти третью цифру числа или сообщить, что её нет.

// Console.Write("введите число: ");
// string num = Console.ReadLine();
// if (num.Length < 3) System.Console.WriteLine($"в числе {num} нет третьей цифры");
// else System.Console.WriteLine(num[2]);

// 15. Дано число. Проверить кратно ли оно 7 и 23.

// int num = new Random().Next(1, 1000);
// System.Console.WriteLine($"дано число {num}");
// if (num % 7 == 0 && num % 23 == 0) System.Console.WriteLine("Да");
// else System.Console.WriteLine("Нет");

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

// int num = new Random().Next(1, 8);
// Console.WriteLine($"Дано число обозначающее день недели - {num}");
// if (num <= 5) Console.WriteLine("этот номер дня недели не является выходным");
// if (num > 5 && num < 8) Console.WriteLine("этот номер дня недели является выходным");

// 17. По двум заданным числам проверять является ли одно квадратом другого.

// Console.WriteLine("введите число 1: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine("введите число 2: ");
// int Num = int.Parse(Console.ReadLine());
// if (num == Num * Num | Num == num * num) Console.WriteLine("Является");
// else Console.WriteLine("не вляется");

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// Console.WriteLine("введите значение по оси x: ");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("введите значение по оси y: ");
// int y = int.Parse(Console.ReadLine());
// if (x > 0 & y > 0) Console.WriteLine("1 четверть");
// if (x > 0 & y < 0) Console.WriteLine("2 четверть");
// if (x < 0 & y < 0) Console.WriteLine("3 четверть");
// if (x < 0 & y > 0) Console.WriteLine("4 четверть");


// 20. Задать номер четверти, показать диапазоны для возможных координат.

// int quarter = int.Parse(Console.ReadLine());
// if (quarter == 1) Console.WriteLine("диапазоны для возможных координат по x > 0 и по y > 0"); 
// if (quarter == 2) Console.WriteLine("диапазоны для возможных координат по x > 0 и по y < 0"); 
// if (quarter == 3) Console.WriteLine("диапазоны для возможных координат по x < 0 и по y < 0"); 
// if (quarter == 4) Console.WriteLine("диапазоны для возможных координат по x < 0 и по y > 0"); 

// 21. Программа проверяет пятизначное число на палиндромом.

// System.Console.WriteLine("введите пятизначное число");
// string num = Console.ReadLine();
// if (num.Length == 5)
// {
//     int i = 0;
//     int count = 1;
//     while (i <= num.Length / 2)
//     {
//         if (i == num.Length / 2)
//         {
//             Console.WriteLine($"число {num} является палиндромом");
//             // break;
//         }

//         if (num[i] != num[num.Length - count])
//         {
//             Console.WriteLine("это число не является палиндромом");
//             break;
//         }
//         i++;
//         count++;
//     }
// }
// else Console.WriteLine("я сказал пятизначное число ввести!!!");

// 22. Найти расстояние между точками в пространстве 2D/3D. AB = √(xb - xa)^2 + √(yb - ya)^2 

// int xa = 7;
// int ya = 6;
// int xb = 9;
// int yb = 8;
// double res = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
// Console.WriteLine(res);

// 23. Показать таблицу квадратов чисел от 1 до N.

// int N = new Random().Next(3,10);
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
// }

// 24. Найти кубы чисел от 1 до N

// int N = new Random().Next(3,10);
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
// }

// 25. Найти сумму чисел от 1 до А.

// int A = new Random().Next(2,10);
// int sum = 0;
// int res = 0;
// for (int i = 1; i <= A; i++)
// {
//     res = sum + i;
//     sum = res;   
// }
// Console.WriteLine($"сумму чисел от 1 до {A} = {res}");

// 26. Возведите число А в натуральную степень B используя цикл.

// int A = new Random().Next(1,10);
// int B = new Random().Next(1,10);
// int res = 0;
// int mult = 1;
// for (int i = 1; i <= B; i++)
// {
//     res = mult * A;
//     mult = res;
// }
// Console.WriteLine($"{A}^{B} = {res}");

// 27. Определить количество цифр в числе.

// Console.Write("введите число: ");
// int num = int.Parse(Console.ReadLine());
// string str = string.Empty;
// while (num > 0)
// {
//     str = (num % 10) + str;  
//     num = num / 10;  
// }
// System.Console.WriteLine($"в этом числе {str.Length} цифр");

// 28. Подсчитать сумму цифр в числе

// Console.Write("введите число: ");
// int num = int.Parse(Console.ReadLine());
// int number = num;

// string str = string.Empty;
// while (num > 0)
// {
//     str = (num % 10) + str;           // этот цикл создали чтоб выяснить длину массива
//     num = num / 10;
// }

// int[] array = new int[str.Length]; // та самая длина массива - str.Lengt
// for (int i = array.Length - 1; i >= 0; i--)
// {
//     array[i] = number % 10;
//     number /= 10;
// }

// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     sum = sum + array[i];
// }
// Console.WriteLine($"сумма цифр = {sum}");


// 29. Написать программу вычисления произведения чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int N= int.Parse(Console.ReadLine());
// int res = 0;
// for (int i = 1; i <= N; i++)
// {
//     for (int j = 1; j <= N; j++)
//     {
//         res = i * j;
//         Console.WriteLine($"{i} x {j} = {res} ");
//     }
//     Console.WriteLine();
// }

// 30. Показать кубы чисел, заканчивающихся на четную цифру.

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0) System.Console.WriteLine(Math.Pow(array[i], 3));
// }

// 31. Задать массив из 8 элементов и вывести их на экран.

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10);
//     Console.Write($"{array[i]} ");
// }

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,2);
//     Console.Write($"{array[i]} ");
// }


// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// int SumArray(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         sum = sum + arr[i];
//     }
//     return sum;
// }

// int[] collection = new int[12];
// FillArray(collection);
// PrintArray(collection);
// Console.WriteLine();
// int sum = SumArray(collection);
// System.Console.WriteLine(sum);

// 34. Написать программу замену элементов массива на противоположные.

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
// }

// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         Console.Write($"{a[i]} ");
//     }
// }

// void Replacement(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * -1;
//     }
// }

// int[] coll = new int[9];
// FillArray(coll);
// PrintArray(coll);
// Console.WriteLine();
// Replacement(coll);
// PrintArray(coll);

// 35. Определить, присутствует ли в заданном массиве, некоторое число.

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
// }

// void PrintArray(int[] coll)
// {
//     for (int i = 0; i < coll.Length; i++)
//     {
//         Console.Write($"{coll[i]} ");
//     }
// }

// void FindNumber(int[] numbers, int num, int count = 0)
// {
//     // int count = 1;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (num == numbers[i]) count ++;
//     }
//     if(count > 0) Console.WriteLine($"присуттсвует {count} раз");
//     else Console.WriteLine("не присуттсвует");
// }

// int[] collection = new int[30];
// int number = 5;
// FillArray(collection);
// PrintArray(collection);
// System.Console.WriteLine();
// FindNumber(collection, number);

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] coll)
// {
//     for (int i = 0; i < coll.Length; i++)
//     {
//         Console.Write($"{coll[i]} ");
//     }
//     Console.WriteLine();
// }

// void ShowNumbers(int[] arr, int PositiveNum, int NegativeNum)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) PositiveNum++;
//         else NegativeNum++;
//     }
//     Console.WriteLine($"количество четных чисел = {PositiveNum}");
//     Console.WriteLine($"количество нечётных чисел = {NegativeNum}");
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// ShowNumbers(array, 0, 0);

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

// int[] array = new int[123];
// int count = 0;
// for (int i = 10; i < 100; i++)
// {
//     count++;
// }
// Console.WriteLine($"количество элементов из отрезка [10,99] = {count}");

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 1000);
//     }
// }

// void PrintArray(int[] coll)
// {
//     for (int i = 0; i < coll.Length; i++)
//     {
//         Console.Write($"{coll[i]} ");
//     }
//     Console.WriteLine();
// }

// int FindSum(int[] arr, int sum = 0)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 0) sum = sum + arr[i];
//     }
//     return sum;
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// int sum = FindSum(array);
// Console.WriteLine(sum);

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
// }

// void PrintArray(int[] coll)
// {
//     for (int i = 0; i < coll.Length; i++)
//     {
//         Console.Write($"{coll[i]} ");
//     }
//     Console.WriteLine();
// }

// void ProductOfNumbers(int[] array, int res = 0, int count = 1)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         res = array[i] * array[array.Length - count];
//         count++;
//         Console.Write($"{res}, ");
//     }
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.Write($"произведение пар чисел = ");
// ProductOfNumbers(array);

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void FillArray(int[] coll)
// {
//     for (int i = 0; i < coll.Length; i++)
//     {
//         coll[i] = new Random().Next(0, 10);
//     }
// }

// int FindMax(int[] array, int max = 0)
// {
//     max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (max < array[i]) max = array[i];
//     }
//     return max;
// }

// int FindMin(int[] coll, int min = 0)
// {
//     min = coll[0];
//     for (int i = 1; i < coll.Length; i++)
//     {
//         if (min > coll[i]) min = coll[i];
//     }
//     return min;
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// int max = FindMax(array);
// int min = FindMin(array);
// int res = max - min;
// Console.WriteLine($"разницу между максимальным и минимальным элементом = {res}");

// 41. Выяснить являются ли три числа сторонами треугольника ( a+b>c и b+c>a и a+c>b).

// int a = new Random().Next(1, 10);
// int b = new Random().Next(1, 10);
// int c = new Random().Next(1, 10);
// if (a + b > c && b + c > a && a + c > b) Console.WriteLine($"числа: {a}, {b}, {c} являются сторонами треуголтника");
// else Console.WriteLine($"числа: {a}, {b}, {c} не являются сторонами треуголтника");

// 42. Определить сколько чисел больше 0 введено с клавиатуры.

// int amount = 3;
// int count = 0;
// for (int i = 0; i < amount; i++)
// {
//     Console.WriteLine("введите число");
//     int num = int.Parse(Console.ReadLine());
//     if (num > 0) count++;
// }
// Console.WriteLine($"чисел больше 0 введено с клавиатуры {count}");

// 43. Написать программу преобразования десятичного числа в двоичное.

// Console.WriteLine("введите число: ");
// int num = int.Parse(Console.ReadLine());
// int numm = num;
// string binary = string.Empty;
// while (num > 0)
// {
//     binary = binary + num % 2;
//     num /= 2;
// }
// Console.WriteLine($"десятичное число {numm} = двоичному {binary}");

// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

// int k1 = new Random().Next(1,10);
// int b1 = new Random().Next(1,10);
// int k2 = new Random().Next(1,10);
// int b2 = new Random().Next(1,10);
// //  условия задачи не понятны!

// 45. Показать числа Фибоначчи.

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// Console.WriteLine(Fibonacci(3));

// 46. Написать программу масштабирования фигуры.
//  условия задачи не понятны!

// 47. Написать программу копирования массива.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// string coll = string.Empty;
// for (int i = 0; i < array.Length; i++)
// {
//     coll += $"{array[i]} ";
// }
// Console.WriteLine(coll);

// 48. Показать двумерный массив размером m×n заполненный целыми числами.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("введите колличество строк:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("введите колличество столбцов:");
// int n = int.Parse(Console.ReadLine());
// int[,] matrix = new int[m, n];
// FillArray(matrix);
// PrintArray(matrix);


// 49. Показать двумерный массив размером m×n заполненный вещественными числами.

// void FillArray(double[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(double[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("введите колличество строк:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("введите колличество столбцов:");
// int n = int.Parse(Console.ReadLine());
// double[,] matrix = new double[m, n];
// FillArray(matrix);
// PrintArray(matrix);

// 50. В двумерном массиве n×k заменить четные элементы на противоположные.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Replacement(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             if (mat[i, j] % 2 == 0) Console.Write($"{mat[i,j] * -1} ");
//             else System.Console.Write($"{mat[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Replacement(matrix);

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n.

// void Replace(int[,] array, int m, int n)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = m + n;
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int rows = 3;
// int colums = 4;
// int[,] matrix = new int[rows, colums];
// Replace(matrix, rows, colums);
// PrintArray(matrix);


// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Replace(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) mat[i, j] = mat[i, j] * mat[i, j];
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Replace(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("строка");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("столбец");
// int n = int.Parse(Console.ReadLine());
// if (m > matrix.GetLength(0) || n > matrix.GetLength(1)) Console.WriteLine("такого элемента нет");
// else Console.WriteLine($"позиции числа = {matrix[m - 1, n - 1]}");

// 54. В матрице чисел найти сумму элементов главной диагонали.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int Sum(int[,] mat, int sum = 0, int m = 0, int n = 0)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         sum = sum + mat[m, n];
//         m++;
//         n++;
//     }
//     return sum;
// }

// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// int sum = Sum(matrix);
// Console.WriteLine($"сумма элементов главной диагонали = {sum}");

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// void Result(int[,] mat)
// {
//     for (int j = 0; j < mat.GetLength(1); j++)
//     {
//         int res = 0;
//         for (int i = 0; i < mat.GetLength(0); i++)
//         {
//             res = res + mat[i, j];

//         }
//         Console.Write($"{res} ");
//     }

// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("=  =  =  =");
// Result(matrix);

// 56. Написать программу, которая обменивает элементы первой строки и последней строки.

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matrix.GetLength(1); colums++)
//         {
//             matrix[rows, colums] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ReplaceRows(int[,] mat, int temporary = 0)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             temporary = mat[0, j];
//             mat[0, j] = mat[mat.GetLength(0) - 1, j];
//             mat[mat.GetLength(0) - 1, j] = temporary;
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// System.Console.WriteLine();
// ReplaceRows(matrix);
// PrintArray(matrix);

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,4:d}", array[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ArraySort(int[,] array)
// {
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int column = 0; column < array.GetLength(1) - 1; column++)
//         {
//             for (int i = column + 1; i < array.GetLength(1); i++)
//             {
//                 if (array[row, column] < array[row, i])
//                 {
//                     int temp = array[row, column];
//                     array[row, column] = array[row, i];
//                     array[row, i] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] array = new int[3, 4];
// FillArray(array);
// PrintArray(array);
// ArraySort(array);
// PrintArray(array);

// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(1); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             matrix[rows, columns] = new Random().Next(1, 100);
//         }
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0,4:d}", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// void Replace(int[,] a)
// {
//     for (int i = 0; i < 4; ++i)
//     {
//         for (int j = 0, k = 4 - 1; j < k; ++j, --k)
//         {
//             int tmp = a[i, j];
//             a[i, j] = a[i, k];
//             a[i, k] = tmp;
//         }
//     }
// }

// int[,] a = new int[4, 4];
// FillArray(a);
// PrintArray(a);
// Console.WriteLine();
// Replace(a);
// PrintArray(a);  // РЕШЕНИЕ НЕ НАЙДЕНО!!!

// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

// void FillArray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             mat[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] m)
// {
//     for (int i = 0; i < m.GetLength(0); i++)
//     {
//         for (int j = 0; j < m.GetLength(1); j++)
//         {
//             Console.Write("{0,3:d}", m[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// void RowSum(int[,] matrix)
// {
//     int pos = 0;
//     int minSum = 100;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         if(sum < minSum)
//         {
//             pos = i + 1;
//             minSum = sum;
//         }

//         System.Console.WriteLine("{0,4:d}", sum);
//     }
//     Console.WriteLine($"наименьшая сумма элементов в {pos} строке");
// }

// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// RowSum(matrix);

// 60. Составить частотный словарь элементов двумерного массива.

// Не знаю как решить эту задачу!

// ## Рекурсия
// 66. Показать натуральные числа от 1 до N, N задано.

// string NumbersRec(int a, int N)
// {
//     if (a <= N) return $"{a} " + NumbersRec(a + 1, N);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10));

// string NumberRec(int N)
// {
//     if (N == 1) return String.Empty + N;
//     else return NumberRec(N - 1) + $" {N}";
// }
// Console.WriteLine(NumberRec(10));


// 67. Показать натуральные числа от N до 1, N задано.

// string NumRec(int N)
// {
//     if (N == 1) return String.Empty + N;
//     else return $"{N} " + NumRec(N-1);
// }
// Console.WriteLine(NumRec(10));

// 68. Показать натуральные числа от M до N, N и M заданы.

// string NumRec(int M, int N)
// {
//     if (M < N) return $"{M} " + NumRec(M + 1, N);
//     if (M > N) return $"{M} " + NumRec(M - 1, N);
//     else return $"{M}";
// }
// Console.WriteLine(NumRec(15, 9));
// Console.WriteLine(NumRec(1, 10));

// 69. Найти сумму элементов от M до N, N и M заданы.

// int NumRec(int M, int N)
// {
//     if (M < N) return N + NumRec(M, N - 1);
//     if (M > N) return M + NumRec(M - 1, N);
//     else return 0;
// }
// Console.WriteLine(NumRec(0, 10));
// Console.WriteLine(NumRec(10, 0));

// 70. Найти сумму цифр числа.

// int SumRec(int num)
// {
//     if (num == 0) return num;
//     else return SumRec(num / 10) + num % 10;
// }
// Console.WriteLine(SumRec(1234));

// 71. Написать программу вычисления функции Аккермана
// 72. Написать программу возведения числа А в целую стень B
// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

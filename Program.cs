
//-------------------------------------------------------------------------------
﻿// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Вариант 1
// string CharOfString(char[,] arr)
// {
//     string st = ""; // обязательно двойные ковычки

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.WriteLine(i);
//             st += arr[i, j];
//         }
//     }
//     return st;
// }

// // Вариант 2
// void CharOfString2(char[,] arr)
// {
//     string st = ""; // 
//     foreach (var i in arr)
//     {
//         Console.WriteLine(i);
//         st += i; // st = st + i
//     }
//     Console.WriteLine(st);
// }


// char[,] chars = new char[,]
// {
//     { 'a', '1' },
//     { 'c', 'd' }
// };
// Console.WriteLine(CharOfString(chars));
// CharOfString2(chars);

// //Ответ
// public class Task1
// {
// //     public static void Main(string[] args)
// //     {
// //         // Инициализация двумерного массива символов
// //         char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
// //         // Вызов метода для создания строки из 2D массива
// //         string result = CreateStringFrom2DArray(charArray);
// //         // Вывод результата
// //         Console.WriteLine(result);
// //     }
// //     // Метод для создания строки из двумерного массива символов
// //     public static string CreateStringFrom2DArray(char[,] array)
// //     {
// //         string result = "";
// //         // Цикл по каждому элементу в двумерном массиве
// //         for (int i = 0; i < array.GetLength(0); i++)
// //         {
// //             for (int j = 0; j < array.GetLength(1); j++)
// //             {
// //                 // Добавление каждого символа в результирующую строку
// //                 result += array[i, j];
// //             }
// //         }
// //         return result;
// //     }
// // }

//-------------------------------------------------------------------------------

﻿// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string text = "gdsKGF34!-0";
// string result = text.ToLower();
// Console.Write(result);


// public class Task2
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
//         // Преобразование всех заглавных букв в строчные
//         string result = input.ToLower();
//         // Вывод результата
//         Console.WriteLine(result);
//     }
// }

//-------------------------------------------------------------------------------

﻿// Задайте произвольную строку. Выясните, является ли она палиндромом. 
// (Справа на лево и слева на право читается одинаково).

// using System.Text;
// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;

// bool IsPalindrom(string str)
// {
//     bool a = false;
//     bool b = false;
//     int count = 0;
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i] == str[str.Length - i - 1])
//         {
//             a = true;
//             if (a)
//             {
//                 count++;
//             }
//         }
//     }
//     if (count == str.Length / 2)
//     {
//         b = true;
//     }
//     return b;
// }

// void Print(bool str)
// {
//     if (str)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// string str = "шалаш";
// bool isPalindrom = IsPalindrom(str);
// Print(isPalindrom);

// public class Task3
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка для проверки
//         string input = "шалаш";
//         // Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
//         // Вывод результата
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }

//-------------------------------------------------------------------------------
﻿// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

// string[] GetInvertedArray(string[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
//     }
//     return array;
// }

// void ShowArray(string[] col)
// {
//     foreach (string item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();

// }

// string str = "Hello my world";
// string[] arr = str.Split(" ");

// string[] res = GetInvertedArray(arr);
// ShowArray(res);


// public class Task4
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со словами, разделенными пробелами
//         string input = "Hello my world";
//         // Вызов метода для обращения порядка слов в строке
//         string result = ReverseWords(input);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для обращения порядка слов в строке
//     public static string ReverseWords(string str)
//     {
//         // Разделение строки на слова
//         string[] words = str.Split(' ');
//         // Обращение порядка слов
//         Array.Reverse(words);
//         // Соединение слов обратно в строку с пробелами
//         return string.Join(" ", words);
//     }
// }
//-------------------------------------------------------------------------------

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// string PrintNaturalNumbers(int m, int n)
// {
//     if (m == n) return Convert.ToString(n);
//     return m + " " + PrintNaturalNumbers(m + 1, n);
// }

// void PrintNaturalNumbers2(int start, int end)
//     {
//         if (start > end) return;
//         Console.Write(start + " ", end);
//         PrintNaturalNumbers2(start + 1, end);
//     }

// Console.WriteLine("Введите число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Натуральные числа от {m} до {n}:");
// Console.WriteLine(PrintNaturalNumbers(m, n));
// PrintNaturalNumbers2(m, n);

//-------------------------------------------------------------------------------

﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m, n)
// n + 1, при m = 0;
// A(m - 1, 1), при m > 0, n = 0;
// A(m - 1, A(m, n - 1)), при m > 0, n > 0;

// int AkkermanFunction (int m, int n)
// {
//     if(m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0) 
//     {
//         return AkkermanFunction(m - 1, 1);
//     }
//     else 
//     {
//         return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     }
// }

// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"A({m}, {n}) = {AkkermanFunction(m, n)}");

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     return AkkermanFunction(m, n);
// }

//-------------------------------------------------------------------------------

﻿// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// void Reverse (int[] array, int i)
// {
//     if(i < 0) return;
//     Console.Write(array[i] + " ");
//     Reverse(array, i - 1);
// }

// int[] array = {34, 5, 67, 32, 0};
// Reverse(array, array.Length - 1);
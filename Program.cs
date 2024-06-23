//-------------------------------------------------------------------------------
// Урок 2. Простые Алгоритмы
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// Console.Clear();

// while (true)
// {
//     Console.Write("Введите число или 'q' для выхода: ");
//     string input = Console.ReadLine();
//     if (input == "q")
//     {
//         break;
//     }
//     int number;
//     if (int.TryParse(input, out number))
//     {
//         int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     if (sum % 2 == 0)
//     {
//         Console.WriteLine("[STOP]");
//         break;
//     }
//     }

// else
// {
//     Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
// }
// }
//-------------------------------------------------------------------------------

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int[] CreateRandomeArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for(int i = 0; i < N; i ++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] Array1 = CreateRandomeArray(5, 100, 999);
// ShowArray(Array1);

// int possitive = 0;
// for(int i = 0; i < Array1.Length; i++)
// {
//     if(Array1[i] % 2 == 0)
//     {
//         possitive++;
//     }
// }
// Console.WriteLine($"Колличество четных чисел в массиве: {possitive}");
//-------------------------------------------------------------------------------

//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)

// int[] CreateRandomeArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for(int i = 0; i < N; i ++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] massive = CreateRandomeArray(6, 10, 99);
// ShowArray(massive);

// for(int j = 0; j < massive.Length/2; j++)
// {
//     int temp = massive[j];
//     massive[j] = massive[massive.Length-1-j];
//     massive[massive.Length-1-j] = temp;
// }
// ShowArray(massive);
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
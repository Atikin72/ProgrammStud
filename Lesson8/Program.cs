// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в
// массиве. Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// Мой вариант
// int[] mass = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int i = 0;
// Console.WriteLine("Введите индекс элемента:");
// int n = Convert.ToInt32(Console.ReadLine());

// while (i < mass.Length)
// {
//     if (mass[i] == n)
//     {
//         Console.WriteLine("Элемент в массиве " + mass[i] + " есть равный введёному числу " + n );
//         break;
//     }
//     else
//     {
//         i++; // Увеличиваем индекс, чтобы не застрять в бесконечном цикле
//     }
// }

// if (i == mass.Length)
// {
//     Console.WriteLine("Элемент равный введёному числу " + n + " отсутствует в массиве");
// }

// ___
 
 // int[] array1 = new int[5];
// int[] array2 = new int[5] { 3, 6, 8, 3, 9 };
// int[] array3 = new int[] { 3, 6, 8, 3, 9 };

// Вариант учителя
// int[] array = {1, 3, 8, 19, 3, 8};
// int num = 8;

// bool isExistNum = false;

// for (int i = 0; i < array.Length; i++)
// {
// if(array[i] == num)
// {
// isExistNum = true;
// break;
// }
// }

// // int number = 45;

// // if(number > num) Console.WriteLine("Ура!");
// // if(!(number < num)) Console.WriteLine("Ура!");

// //string result = isExistNum ? "Да" : "Нет";
// Console.WriteLine(isExistNum ? "Да" : "Нет");

// ______________________________________________

// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные
// элементы на положительные, а положительные на отрицательные.
// Пример

// [1 -5 6]
// => [-1 5 -6]

// int[] array = new int[10] { -3, 4, -5, 6, 8, -4, 7, 9, -1, 3 };

// for (int i = 0; i < array.Length; i++)
// {
// array[i] *= -1; // array[i] = array[i] * -1;

// }

// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }

// ______________________________________________


// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]
// (элемент 7 не имеет пары)

// int[] array = { 2, 3, 1, 7, 5, 6, 3 };
// int[] arrayResult = new int[array.Length / 2];

// int left = 0;
// int right = array.Length - 1;

// while (left < right)
// {
// arrayResult[left] = array[left] * array[right];
// left++;
// right--;
// }

// for (int i = 0; i < arrayResult.Length; i++)
// {
// Console.Write(arrayResult[i] + " ");
// }

// ______________________________________________


// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд
// числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// int num;
// Console.Write("Введите трехзначное число: ");
// num = Convert.ToInt32(Console.ReadLine());

// int numCopy = num;
// int count = 0;

// // счетает количество цифр в числе
// while(numCopy != 0){
// numCopy /= 10;
// count++;
// }


// int[] arr = new int[count]; // создаем массив на количество цифр
// int index = arr.Length - 1; // индекс последнего элемента
// while(num != 0){
// arr[index] = num % 10;
// num /= 10; // num = num / 10;
// index--;
// }

// for(int i = 0; i < arr.Length; i++){
// Console.Write(arr[i]);
// }

// Наоборт

// int num;
// Console.Write("Введите трехзначное число: ");
// num = Convert.ToInt32(Console.ReadLine());

// int numCopy = num;
// int count = 0;

// // счетает количество цифр в числе
// while(numCopy != 0){
// numCopy /= 10;
// count++;
// }


// int[] arr = new int[count]; // создаем массив на количество цифр
// int index = 0; // индекс последнего элемента
// while(num != 0){
// arr[index] = num % 10;
// num /= 10; // num = num / 10;
// index++;
// }
// Console.Write("[");
// for(int i = 0; i < arr.Length; i++){
// Console.Write($"{arr[i]} ");
// }
// Console.Write("]");
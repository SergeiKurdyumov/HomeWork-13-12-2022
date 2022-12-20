

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GeneratorMassiv(int size, int min, int max){
// int[] array = new int [size];
// for (int i = 0; i < size; i++)
// {    array[i] = new Random().Next(min,max); }
//     return array;
// }

// void ShowMassiv(int[] array){
// for(int i = 0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }
// int EvenNumbers(int[] array){
//     int koLNchestvo = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] % 2 == 0) koLNchestvo = koLNchestvo + 1;
//     }
//     return koLNchestvo;
// }

// int size = 10;
// int min = 100;
// int max = 1000;
// int[] dlina = GeneratorMassiv(size, min, max);
// ShowMassiv(dlina);
// int result = EvenNumbers(dlina);
// Console.Write(result);



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GeneratorMassiv(int size, int min, int max){
// int[] array = new int [size];
// for (int i = 0; i < size; i++)
// {    array[i] = new Random().Next(min,max); }
//     return array;
// }

// void ShowMassiv(int[] array, int minA, int maxB){
// for(int i = 0; i < array.Length; i++){
//     if (array[i] >= minA && array[i] <= maxB)
//         {Console.ForegroundColor = ConsoleColor.Red;
//         Console.Write($"{array[i]} ");}
//     else {Console.ForegroundColor = ConsoleColor.Gray;
//         Console.Write($"{array[i]} ");}
// }
// Console.WriteLine();
// }
// int NumbersInLine(int[] array, int minA, int maxB){
//     int koLNchestvo = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] >= minA && array[i] <= maxB) 
//         koLNchestvo = koLNchestvo + 1;
//     }
//     return koLNchestvo;
// }

// int size = 123;
// int min = 1;
// int max = 1000;
// int minA =10;
// int maxB = 99;
// int[] dlina = GeneratorMassiv(size, min, max);
// ShowMassiv(dlina,minA,maxB);
// int result = NumbersInLine(dlina, minA, maxB);
// Console.Write(result);





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GeneratorMassiv(int size, int min, int max){
// int[] array = new int [size];
// for (int i = 0; i < size; i++)
// {    array[i] = new Random().Next(min,max); }
//     return array;
// }

// void ShowMassiv(int[] array){
// for(int i = 0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }
// int SumEvenNumbers(int[] array){
//     int koLNchestvo = 0;
//     int i = 1;
//     while (i < array.Length){
//     koLNchestvo = koLNchestvo + array[i];
//     i = i + 2;}
//     return koLNchestvo;
// }

// int size = 9;
// int min = 1;
// int max = 10;
// int[] dlina = GeneratorMassiv(size, min, max);
// ShowMassiv(dlina);
// int result = SumEvenNumbers(dlina);
// Console.Write(result);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] GeneratorMassiv(int size, int min, int max){
// int[] array = new int [size];
// for (int i = 0; i < size; i++)
// {    array[i] = new Random().Next(min,max); }
//     return array;
// }

// void ShowMassiv(int[] array){
// for(int i = 0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }
// int NumbersDifference(int[] array, int min, int max){
//     for (int i = 0; i < array.Length; i++){
//     if (array[i] < min) min = array[i];
//     if (array[i] > max) max = array[i];}
//     int result = max - min;
//     return result;
// }

// int size = 15;
// int min = 1;
// int max = 1000;
// int[] dlina = GeneratorMassiv(size, min, max);
// ShowMassiv(dlina);
// int result = NumbersDifference(dlina,max,min);
// Console.Write(result);



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] GeneratorMassiv(int size, int min, int max){
// int[] array = new int [size];
// for (int i = 0; i < size; i++)
// {    array[i] = new Random().Next(min,max); }
//     return array;
// }

// void ShowMassiv(int[] array){
// for(int i = 0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }
// void NumbersProduct(int[] array){
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array [i] * (array[array.Length - 1 - i]);
//     Console.Write($"{temp} ");
// }
// }

// void NumbersProduct2(int[] array){
//     for (int i = 0; i < array.Length /2; i++)
//     {
//         int temp = array [i] * (array[array.Length - 1 - i]);
//     Console.Write($"{temp} ");
// }
//     int temp1 = array[array.Length/2] ;
//     Console.Write($"{temp1} ");
// }
// Console.WriteLine("Введите число ");
//     int size = Convert.ToInt32(Console.ReadLine());

// int min = 2;
// int max = 5;
// int[] dlina = GeneratorMassiv(size, min, max);
// ShowMassiv(dlina);
// if (size % 2 ==0) NumbersProduct(dlina);
// if (size % 2  > 0) NumbersProduct2(dlina);


// Результат запишите в новом массиве, вывел результат строкой,
//  так как понятия не имею как записать результат в новый массив, или что-то не допонял.
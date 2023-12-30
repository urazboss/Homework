//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [2,3];
FillArrayRandomNumbers(numbers);

if (a > numbers.GetLength(0) || b > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {numbers[a-1,b-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-50, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Создание матрицы

       int[,] array = {
           {4, 3, 1},
           {2, 6, 9},
           {4, 6, 2}
       };

       Console.WriteLine("Исходный массив:");
       PrintArray(array);

        //Меняем местами первую и последнюю строки
       SwapFirstAndLastRow(array);

       Console.WriteLine("Массив после замены:");
       PrintArray(array);
    

   static void SwapFirstAndLastRow(int[,] array)
   {
       int rows = array.GetLength(0);
       int cols = array.GetLength(1);

       int[] temp = new int[cols];
        
        //Копируем первую строку во временный массив
       for (int i = 0; i < cols; i++)
       {
           temp[i] = array[0, i];
       }

        //Копируем последнюю строку в первую
       for (int i = 0; i < cols; i++)
       {
           array[0, i] = array[rows - 1, i];
       }

        //Копируем временный массив (первую строку) в последнюю
       for (int i = 0; i < cols; i++)
       {
          array[rows - 1, i] = temp[i];
       }
   }

   static void PrintArray(int[,] array)
   {
       for (int i = 0; i < array.GetLength(0); i++)
       {
           for (int j = 0; j < array.GetLength(1); j++)
           {
               Console.Write(array[i, j] + " ");
           }
           Console.WriteLine();
       }
   }

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
int Prompt(string message)
{
Console.Write(message);
 int result = Convert.ToInt32(Console.ReadLine());
 return result;
}

int[,] CreateArray(int m, int n)
{
 int[,] array = new int[m, n];
 return array;
}

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
   for (int j = 0; j < array.GetLength(1); j++)
   {
     Console.Write($"{array[i, j]} ");
   }
   Console.WriteLine();
 }
}

int[,] FillArrayRandom(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
   for (int j = 0; j < array.GetLength(1); j++)
   {
    array[i, j] = new Random().Next(1, 10);
   }
 }
 return array;
}

int SumRowArray(int[,] array)
{
 int[] sumArr = new int[array.GetLength(0)];
 Console.WriteLine($"Сумма по строке:");
 for (int i = 0; i < array.GetLength(0); i++)
 {
   for (int j = 0; j < array.GetLength(1); j++)
   {
     sumArr[i] += array[i, j];
   }
  Console.WriteLine($"{i + 1} -> {sumArr[i]}");
 }
 int minSum = sumArr[0];
 int minRow = 1;
 for (int i = 0; i < array.GetLength(0); i++)
 {
   if (sumArr[i] < minSum)
   {
     minSum = sumArr[i];
     minRow = i + 1;
   }
 }
 return minRow;
}

int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
array = FillArrayRandom(array);
PrintArray(array);
int row = SumRowArray(array);
Console.WriteLine($"Наименьшая сумма в {row} строке.");


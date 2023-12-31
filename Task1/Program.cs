﻿// Напишите программу, которая подсчитывает количество 
// четных элементов в массиве целых положительных трехзначных чисел 
// и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, 
// который принимает массив целых положительных трехзначных чисел и 
// возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, 
// который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// 124, 378, 593, 821, 456
// 675, 234, 789, 102, 356, 849, 763, 198, 524, 937
// 369, 458, 732, 105, 847, 621, 283, 594, 176, 420, 893, 642, 719, 536, 918
// 287, 615, 943, 752, 381, 564, 129, 476, 648, 305, 814, 967, 204, 539, 671, 832, 198, 426, 753, 629


int[] array = {124, 378, 593, 821, 456};
PrintArray(array);
Console.WriteLine(CountEvenElements(array));

static void PrintArray(int[] array)
{
Console.Write($"{array[0]}");
for (int i=1; i<array.Length; i++)
    {
        Console.Write($"\t{array[i]}");
    }
Console.WriteLine();
}

static int CountEvenElements(int[] array)
{
int evenCount = 0;
  for (int i=0; i<array.Length; i++)
  {
  if (array[i] % 2 == 0) evenCount++;
  }
  return evenCount;
}

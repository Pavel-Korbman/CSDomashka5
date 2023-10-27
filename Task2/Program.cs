// Напишите программу, которая находит сумму элементов с нечетными индексами 
// в одномерном массиве целых чисел и выводит результат на экран.

// Программа должна иметь метод SumOddElements, 
// который принимает массив целых чисел 
// и возвращает сумму элементов с нечетными индексами в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Аргументы, передаваемые в метод/функцию:

int[] array = {18, 76, 11};
PrintArray(array);
Console.WriteLine(SumOddElements(array));

int SumOddElements(int[] array)
    {
    int sumOdd = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
     sumOdd += array[i];
    }
    return sumOdd;
    }

void PrintArray(int[] array)
{
Console.Write($"{array[0]}");
for (int i=1; i<array.Length; i++)
    {
        Console.Write($"\t{array[i]}");
    }
Console.WriteLine();
}


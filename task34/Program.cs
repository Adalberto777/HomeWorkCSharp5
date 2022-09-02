//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int[] GetArray(int size, int minValue, int maxValue) //функция GetArray с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                    //заполненный случайными числами
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

void PrintArray(int[] array) // печать элнментов массива заполненного случайными числами
{
  Console.WriteLine("Вывод массива заполненного случайными числами: ");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "| ");
  }
  Console.WriteLine("");
}

int ContLimitArray(int[] array) // печать элнментов массива заполненного случайными числами
{
    int count = 0;
    foreach (int value in array)
    {
        count += value % 2 == 0 ? 1:0;
    }
  return count;
}


int[] array = GetArray(10, 100, 1000); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
PrintArray(array);

Console.WriteLine();
Console.WriteLine($" количество четных чисел в массиве: {ContLimitArray(array)}");

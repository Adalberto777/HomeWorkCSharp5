//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

int MinIndex(int[] array) // метод поиска индекса минимального числа в массиве
{
    int minindex = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            minindex = i;
        }
    }
  return minindex;
}

int MaxIndex(int[] array) // метод поиска индекса максимального числа в массиве
{
    int maxindex = 0;
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
           max = array[i];
           maxindex = i;
        }
    }
  return  maxindex;
}


int[] array = GetArray(10, 1, 999); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"разница между максимальным ({array[MaxIndex(array)]}) и минимальным ({array[MinIndex(array)]}) элементами массива = {array[MaxIndex(array)] - array[MinIndex(array)]}");

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

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

int SumOdd(int[] array) // метод поиска суммы элементов с нечетными индексами
{
    int count = 0;
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 !=0)
        {
            sum = sum + array[i];
        }
    }
  return sum;
}


int[] array = GetArray(4, -100, 100); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"сумма элементов массива с не четными индексами: {SumOdd(array)}");
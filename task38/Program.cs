// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[] array = FillArray(3, 0, 100);
    Console.WriteLine();
    FindResult(array);
    

    Console.WriteLine("\nEnd");
}

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int FindMin(int[] array)
{
    int minPosition = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minPosition) minPosition = array[i];
    }
    Console.WriteLine($"Минимальный элемент массива - {minPosition}");
    return minPosition;
}
int FindMax(int[]array)
{
    int maxPosition = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxPosition)  maxPosition = array[i];
    }
    Console.WriteLine($"Минимальный элемент массива - {maxPosition}");
    return maxPosition;
}
int FindResult(int[]array)
{
    int result =0;
    result = FindMax(array)-FindMin(array);
    Console.WriteLine($"Разница = {result}");
    return result;
}
Main();
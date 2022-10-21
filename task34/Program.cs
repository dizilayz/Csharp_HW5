// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]array = FillArray(10, 100,1000);
    Console.WriteLine();
    int count = EvenNumbers(array);
    Console.WriteLine(count);
}

int[]FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int EvenNumbers(int[]array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }

    return count;
}

Main();

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[] array = FillArray(4, 0, 10);
    int result = OddPosSum(array);
    Console.WriteLine();
    Console.WriteLine(result);

}
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]} ");
    }
    return (array);
}
int OddPosSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum +=array[i];
    }
    return sum;
 
}


Main();
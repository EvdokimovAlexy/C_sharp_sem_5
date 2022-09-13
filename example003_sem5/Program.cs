// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];  
Console.WriteLine("Input Number");
int number = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine(FindNumber(array));


int FindNumber(int[] array)
{   
    int result = 0; 
    for(int i = 0; i < array.Length; i++)
    {
        if( 10 <= array[i] && array[i] <= 99)
        {
            result++; 
        } 
    }
    return result; 
}   

void FillArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(0,100); 
        index++; 
    }
}

void PrintArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        Console.Write($"{array[index]}, ");  
        index++;      
    }
}

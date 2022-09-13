// // Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = new int[10];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
ChangeNumbers(array);
PrintArray(array);

void ChangeNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; 
    }
}

void FillArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(-10,11); 
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

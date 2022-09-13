// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент,
//  второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] array = new int[new Random().Next(10, 15)];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
PrintArray(GetSumPairs(array));


int[] GetSumPairs(int[] array)
{   
    int newLength = 0; 
    if(array.Length % 2 == 0)
    {
        newLength = array.Length / 2; 
    }
    else 
    {
         newLength = array.Length / 2 + 1; 
    }
    int[] result = new int[newLength]; 
    int count = 0; 
    for(int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {   
        if(count < newLength)
        {
            if(i == j && array.Length % 2 != 0)
            {
                result[count] = array[i]; 
                count++; 
            }
            else
            {
                result[count] = array[i] * array[j]; 
                count++; 
            }
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
        array[index] = new Random().Next(1, 10); 
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
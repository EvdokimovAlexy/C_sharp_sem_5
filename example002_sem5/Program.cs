// Задача 33: Задайте массив. Напишите программу,
//  которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] array = new int[10];  
Console.WriteLine("Input Number");
int number = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine(FindNumber(array, number));


bool FindNumber(int[] array, int number)
{   
    bool result = false; 
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        {
            result = true; 
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

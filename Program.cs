// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.


/*Console.WriteLine("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] Array = GetArray(size, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindEven(Array);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindEven(int[] MyArray)
{
    int even = 0;
    for(int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i]%2 == 0)
        {
            even = even + 1;
        }
    }
    Console.WriteLine($"Even numbers {even}");
}*/

// Задача 36:Задайте массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int result = 0;
 Console.WriteLine("Enter the number of array elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[size];
 for(int i = 0; i < array.Length; i++)
 {
    array[i] = Convert.ToInt32(Console.ReadLine());
 }
 if (array[i] %2 != 0)
 {
    result += array[i];
 }
 Console.WriteLine($"The sum of odd array elements is {result}");
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

void FillArrayRandomNumbers(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,99);
    }
}
void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}

Console.WriteLine();
Console.WriteLine(result);
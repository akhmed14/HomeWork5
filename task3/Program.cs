// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] numbers = new int [size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int maxFillarray = numbers[0];
int minFillarray = numbers[0];

void FillArrayRandomNumbers(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,99);
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
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine();
Console.WriteLine(maxFillarray - minFillarray);
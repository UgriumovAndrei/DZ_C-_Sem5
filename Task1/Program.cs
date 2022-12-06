//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int [] array = new int [5];
int count = 0;
for(int i = 0; i<5; i++)
{
    array[i] = new Random(). Next(100,1000);
    Console.Write($"{array[i]} ");
    if(array[i] % 2 == 0)
        count++;
}
Console.WriteLine();
Console.Write($"Количество чётных чисел: {count}");

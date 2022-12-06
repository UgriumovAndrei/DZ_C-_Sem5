// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int [] array = new int [6];
void FillArrayRand(int[]arr)
{
    for(int index = 0; index<arr.Length; index++)
    arr[index] = new Random(). Next(1, 1000);
}
FillArrayRand(array);
string str = string.Join(" ", array);
Console.WriteLine(str);
int sum = 0;
int i = 1;
while(i<array.Length)
{
    sum+= array[i];
    i +=2;
}
Console.Write(sum);


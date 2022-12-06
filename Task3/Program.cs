// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double [] array = new double [5];
void FillArrayRand(double[]arr)
{
    for(int index = 0; index<arr.Length; index++)
    arr[index] = Convert.ToDouble(new Random(). Next(1, 1000));
}

FillArrayRand(array);
string str = string.Join(" ", array);
Console.WriteLine(str);

double max = array[0];
double min = array[0];
for (int i = 0; i<array.Length; i++)
{
    if(array[i]>max)
    max = array[i];
    if(array[i]<min)
    min = array[i];
}
Console.Write(max - min);
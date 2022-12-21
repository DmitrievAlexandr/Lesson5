//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Random random = new Random();
int[]arr=new int [8];
for (int i=0; i<arr.Length;i++)
    arr[i]=random.Next(10, 100);
Console.WriteLine(string.Join(", ",arr));
Console.WriteLine(" Сумма элиментов = "+OddSumElements(arr));

int OddSumElements(int[] array)
{
    int i=0,b=0,sum=0;
    for ( i=0;i<array.Length;i++)
        if (b==i%2)
            sum=sum+array[i];
    return sum;
}
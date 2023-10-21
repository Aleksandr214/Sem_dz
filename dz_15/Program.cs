//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


int [] GenerateArray(int sizeArray,int leftRange,int rightRange)
{
    int [] newArray=new int[sizeArray];
    Random rand=new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i]=rand.Next(leftRange,rightRange+1);
    }
    return newArray;
}
void PrintArray(int[]arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]+" ");
    }
}

void countArray(int []array)
{   
int sum = 0;

for (int i = 0; i < array.Length; i+=2)
    sum = sum + array[i];

    Console.WriteLine($"всего {array.Length} чисел");
    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");
}

 int[] array=GenerateArray(5,10,99);
PrintArray(array);

countArray(array);
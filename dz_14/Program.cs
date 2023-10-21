//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в массиве.

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
   int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");
}

int []array=GenerateArray(5,100,999);
PrintArray(array);

countArray(array);
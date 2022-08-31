//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int []array = new int[12];
void FillArray(int []array )
{

Random rand  = new Random();

for(int i = 0; i<array.Length;i++)
array[i] = rand.Next(-2,9);
}

void PrintArray(int []array)
{


for( int i = 0; i<array.Length;i++)
{
    Console.WriteLine(array[i]);
}
}

void Summ(int []array)
{


int i,positive,negative,sumpositive,sumnegative;
i = positive = negative = sumpositive = sumnegative = 0;
 

for( i = 0; i<array.Length;i++)

{
    if (array[i]>=0)
         positive++;

else
negative++;
 
}

for(i = 0; i<array.Length;i++)
{


if (array[i]>=0)
    sumpositive+=array[i];

if(array[i]<0)
    sumnegative+=array[i];
}
Console.WriteLine($"The positive elements in array are {positive}");
Console.WriteLine($"The positive elements in array are {negative}");
Console.WriteLine($"The  summ of positive elements in array are {sumpositive}");
Console.WriteLine($"The  summ of negative elements in array are {sumnegative}");

}

 
FillArray(array);
PrintArray(array);
Summ(array);
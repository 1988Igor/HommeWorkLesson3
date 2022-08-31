//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void PrintArray(int[] array)
{

array = new int[8];
for(int i = 0; i<array.Length; i++)
{
    Console.Write( array[i] );
}
Console.Write("/");

for(int i = 0; i<array.Length; i++)
{
    array[i] = array[i]+1;
    Console.Write(array[i]);
}

}

int []myArray = new int[8];
PrintArray(myArray);
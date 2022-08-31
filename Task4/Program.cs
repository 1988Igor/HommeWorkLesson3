//Написать программу вычисления произведения чисел от 1 до N

int []array = {2,3,5,4,8};
int mul = 1;
for (int i =0; i<array.Length;i++)
{
   
                    mul *= array[i];
            
            Console.WriteLine( $"{mul}");
                       
}


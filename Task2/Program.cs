//Возведите число А в натуральную степень B используя цикл
void Fillnumber(int x, int y)
{
 int count = 1;
 double pow = 1;
 while(count<=y)
{
    pow = Math.Pow(x,count);
    count++;
    Console.WriteLine(pow);
}
}

Console.WriteLine("Enter the number A:");
int number = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine();
Console.WriteLine("Enter the number B:");
int number2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine();

Fillnumber(number,number2);
//Показать кубы чисел, заканчивающихся на четную цифру

void Fillnumber(int N)
{


Console.WriteLine("Enter the number N :");
N  = int.Parse(Console.ReadLine()??"0");
while (N %2 !=0)
{
    Console.WriteLine("Wrong number, please introduce an even number: ");
    N  = int.Parse(Console.ReadLine()??"0");
}
    int count  = 1;
while (count<=N)
{
    double result = Math.Pow(count,3);

Console.WriteLine($"{count}*{count}*{count}* = {result};");
count++;
}
    
}
 int x = 0;
 Fillnumber(x);
//Найти кубы чисел от 1 до N
void Fillnumber (int n)
{
int count  = 1;
while (count<=n)
{

double result = Math.Pow(count,3);
Console.WriteLine($"{count}*{count}*{count}* = {result};");
count++;
}

}

Console.WriteLine("Enter the number N :");
int number  = int.Parse(Console.ReadLine()??"0");
Fillnumber(number);


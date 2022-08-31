//Подсчитать сумму цифр в числе

void Fillsumm(int x, int a1, int a2, int a3)

{

        if (x>=100 && x<=999)
        {
                a1 = x/100;
                a2 = x%100/10;
                a3 = x%10;

             Console.WriteLine($" {a1} + {a2} + {a3} = {a1+a2+a3}");
        }

       

        else 
        {
            Console.WriteLine("The number doesn't coresspond with  the range. Please try again .");
            
        }
}

Console.WriteLine("Enter a number between 100 and 999 : ");
int n = int.Parse(Console.ReadLine()?? "0");
int number1 = 0;
 int number2 = 0 ;
  int number3 = 0;

Fillsumm(n, number1, number2, number3);

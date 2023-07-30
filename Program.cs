//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число 1: ");
string strNum1=Console.ReadLine();

Console.WriteLine("Введите число 2: ");
string strNum2=Console.ReadLine();

Console.WriteLine("Введите число 3: ");
string strNum3=Console.ReadLine();

int num1=int.Parse(strNum1);
int num2=int.Parse(strNum2);
int num3=int.Parse(strNum3);

int max=num1;

if(num2>max&&num3<num2)
{
    max=num2;
}
else if (num3>max&&num2<num3)
{
    max=num3;
}

Console.WriteLine($"Максимальное число {max}");
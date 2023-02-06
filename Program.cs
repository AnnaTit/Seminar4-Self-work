Задача - количество цифр в числе - решена, работает

int DigitCount(int number)
{
    int count = 0;
    while(number != 0)
    {
        count++;
        number /= 10;
    }
    return count;
}
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));

Задача 2 Найти факториал - решена, работает
int Factorial(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
        result *= i;
    return result;
}
Console.Write("Enter a number N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(num));

2й вариант решения, без ввода переменной - решено, работает
int Factorial(int number)
{
    int result = 1;
    while(number > 1)
    {
        result *= number;
        number --;
    }
    return result;
}
Console.Write("Enter a number N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(num));
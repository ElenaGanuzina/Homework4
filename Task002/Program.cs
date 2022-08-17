// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum(int number)
{
    number = Math.Abs(number);
    int count = 0;
    int result = 0;
    while(number != 0)
    {
        result = result + number % 10; 
        number = number / 10;
        count++;
    }
    return result;
}

void PrintDigitSum(int number)
{
    Console.WriteLine($"Сумма цифр числа {number} равна {DigitSum(number)}");
}

PrintDigitSum(45);
PrintDigitSum(147);
PrintDigitSum(-715);
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Exponentiation(int a, int b)
{
    int result = 1;
    for(int count = 0; count < b; count++)
    {
        result = result * a;
    }
    return result;
}

void PrintExponentiation(int a, int b)
{
    Console.WriteLine($"{a} в степени {b} равно {Exponentiation(a, b)}");
}

PrintExponentiation(0, 5);
PrintExponentiation(2, 3);
PrintExponentiation(-3, 2);
PrintExponentiation(17, 0);
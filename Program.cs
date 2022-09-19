// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. (метод)
int CreateNumber()
{
    int number = new Random().Next(10, 100);
    return number;
}

int MaxDigit(int number)
{
    int Decinal = number / 10;
    int Ed = number % 10;
    if (Decinal >= Ed)

    {
        return Decinal;
    }
    else
    {
        return Ed;
    }
    
    int a = CreateNumber();
    Console.WriteLine(a);
    int maxDigit = MaxDigit(a);
}
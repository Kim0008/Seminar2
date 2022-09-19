// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
int CreateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int DelSecondDigit(int number)
{
    int S = number / 100;
    int E = number % 10;
    int numberNew = S *10 + E;
    return numberNew;
}
int a = CreateNumber();
Console.WriteLine(a);
int numberNew = DelSecondDigit(a);
Console.WriteLine(numberNew);

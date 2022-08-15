//  Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int usernum = Prompt("Введите трехзначное число");
if (usernum >= 100 && usernum <= 999)
{
    int result = usernum % 100 / 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Условие задачи не соблюдается!Повторите");
}
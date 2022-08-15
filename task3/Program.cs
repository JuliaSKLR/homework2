//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int usernum = Prompt("Введите число");
int result = usernum % 1000 / 100;
if (usernum < 100)
{
    System.Console.WriteLine("третьей цифры нет, повторите ввод");
}
else
{
    System.Console.WriteLine(result);
}

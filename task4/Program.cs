////Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, 
//и проверяет,является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int daynum = Prompt("Введите номер дня недели - ");
if (daynum%6 == 0)
{
    System.Console.WriteLine("Это Суббота, выходной");
}
else if (daynum%7 == 0)
{
    System.Console.WriteLine("Это воскресенье, выходной");

}
else
{
    System.Console.WriteLine("Это будний день");
}
//Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа.

int usernum = new Random().Next(100, 999);
int result1 = usernum % 1000 / 100;
int result2 = usernum % 10;
Console.WriteLine($"Трехзначное: {usernum} Ответ: {result1}{result2} ");
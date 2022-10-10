/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void AnswerToTask(){

int newNumber = (new Random()).Next(100,1000);
Console.WriteLine($"Base number: {newNumber}");
string numberAsString = newNumber.ToString();
int result = int.Parse(numberAsString[1].ToString());
Console.WriteLine($"Result number: {result}");

}

AnswerToTask();

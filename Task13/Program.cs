﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.WriteLine("Введите число: ");
int arrayNumber = Convert.ToInt32(Console.ReadLine());
string arrayNum = Convert.ToString(arrayNumber);
if (arrayNum.Length > 2)
{
  Console.WriteLine("третья цифра " + arrayNum[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}
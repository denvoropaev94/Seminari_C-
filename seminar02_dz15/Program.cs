﻿/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void CheckWeekday(){
    Console.WriteLine("Введите цифру: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if((number==6)||(number==7)){
        Console.WriteLine("Это выходной день!");
    }
    else if (number < 1 || number > 7) {
    Console.WriteLine("это вообще не день недели");
  }
    else{
         Console.WriteLine("Это невыходной день!");
    }
} 
CheckWeekday();
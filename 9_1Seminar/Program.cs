﻿// Задай значение N.Напииши прог которая выведет 
// все натур числа в промежутке от 1 до N при помощи рекурсии.

 void chisla(int a )
 {
     if (a == 0) return;
     chisla(a-1);
     Console.Write($"{a} ");
     
 }
 chisla(5);
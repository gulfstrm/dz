// Напишите программу , которая выводит случайное число
// из отрезка [10,99]  и показывает наибольшую цифручисла.

int MaxNumber(int num)
{
    Console.WriteLine(num);

    if(num % 10 > num / 10)
       return num % 10 ;
    else 
       return num /10;
}

Console.WriteLine(MaxNumber(new Random().Next(10,100)));

// 123456 % 10 -> 6
// 123456 / 10 -> 12345
// 123456 / 100 -> 1234

 // 12 % -> 2
 // 12 / -> 1

// Напиши программу которая принимает на вход трехзначное число
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число:  ");

int n = Convert.ToInt32(Console.ReadLine());

while(n < 100 || n > 999  )
 {
    Console.Write("Вы ошиблись !\n Введите трехзначное число:");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(n/ 10 % 10);
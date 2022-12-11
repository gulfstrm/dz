// Напиши программу которая принимает на вход пятизначное число
// и проверяет является ли оно палиндромом.
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10)
Console.WriteLine("да");
else
Console.WriteLine(" нет");

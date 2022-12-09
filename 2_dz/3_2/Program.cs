// Напиши программу которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.
int n = new Random().Next(100,1000);
Console.WriteLine($"Случайное число:{n}");
int n1 = n/100;
int n2 = n%10;
int n3 = n1*10+n2;
Console.WriteLine(n3);
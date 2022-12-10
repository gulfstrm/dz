//Напишите программу котрая принимает на вход координаты точки
// (X и Y) причем x не равен 0 или y не равен 0 и выдает номер четверти плоскрсти
// в которой находится точка.
void Quarter(int x,int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, or y = 0");
    else if(x > 0 && y > 0)
        Console.WriteLine("I");
    else if(x < 0 && y > 0)
        Console.WriteLine("II");
    else if(x < 0 && y < 0)
        Console.WriteLine("III");
    else if(x > 0 && y < 0)
        Console.WriteLine("IV");
}

Quarters(10, -9);

// Напишите программу котрая по заданому номеру четверти показываетдиапазон 
// возможных координат точек в этой четверти(X и Y).
void Quarters(string a)
{
    if (a == "I")
        Console.WriteLine("x > 0 and y > 0");
    else if(a == "II")
        Console.WriteLine("x < 0 and y > 0");
    else if(a == "III")
        Console.WriteLine("x < 0 and y < 0");
    else if(a == "IV")
        Console.WriteLine("x > 0 and y < 0");
    else 
        Console.WriteLine("error");
}

Quarters(Console.ReadLine());


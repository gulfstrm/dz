// Напиши программу которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
 float ReadNumber(string message)
{
  Console.Write(message);
   var s = Console.ReadLine();
   float a = s == null ? 0 : float.Parse(s);
  return a;
}
double Distance( float ax,float ay,float az,float bx,float by,float bz )
{
    double result;
    result = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));

    return result;
}
float ax = ReadNumber("Введите ax: ");
float ay = ReadNumber("Введите ay: ");
float az = ReadNumber("Введите az: ");
float bx = ReadNumber("Введите bx: ");
float by = ReadNumber("Введите by: ");
float bz = ReadNumber("Введите bz: ");


Console.WriteLine(Distance( ax, ay, az, bx, by, bz ));

// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int KoordinataX(int x)// метод получения координаты X
{
    int x1 = new Random().Next(-10, 10);
    System.Console.WriteLine($"x = {x1}");
    return (x1);
}
int KoordinataY(int y)// метод получения координаты Y
{
    int y1 = new Random().Next(-10, 10);
    System.Console.WriteLine($"y = {y1}");
    return (y1);
}
//====================================================================
int koord = 0;
int Ax = KoordinataX(koord);
int Ay = KoordinataY(koord);


if (Ax > 0 && Ay > 0)
{
    System.Console.WriteLine("1-я четверть");
}
if (Ax < 0 && Ay > 0)
{
    System.Console.WriteLine("2-я четверть");
}
if (Ax < 0 && Ay < 0)
{
    System.Console.WriteLine("3-я четверть");
}
if (Ax > 0 && Ay < 0)
{
    System.Console.WriteLine("4-я четверть");
}
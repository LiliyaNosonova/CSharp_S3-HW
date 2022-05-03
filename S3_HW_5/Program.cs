// 5.Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Koordinaty (string text)// метод получения данных
{    
    Console.WriteLine($"{text}; ");
    string getvalueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getvalueStr);
    return value;    
}

double Pifagor (int ax, int ay, int az, int bx, int by, int bz) //метод рассчета расстояния по теореме Пифагорa
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + 
            Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}
int Ax = Koordinaty("Ax");
int Ay = Koordinaty("Ay");
int Az = Koordinaty("Az");
int Bx = Koordinaty("Bx");
int By = Koordinaty("By");
int Bz = Koordinaty("Bz");

double result = Pifagor (Ax, Ay, Az, Bx, By, Bz);
System.Console.WriteLine(result);

// 4. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Perevorot(int N2)// Метод переворота заданного числа
{
    int M = Math.Abs(N2);
    int q = 0;
    int n = 0;
    int newN = 0; // новая переменная для перевернутого числа
    while (M > 0)
    {
        q = M % 10;
        newN = newN * 10 + q; // переворот числа 
        M = M / 10;
        n++;
    }
    return newN;
    //System.Console.WriteLine($"{newN,10} {q} {n}");
}

//=====================================================
//int N = 15651;
int N = new Random().Next(10000, 100000);
int newN = Perevorot(N);
//string newN = Convert.ToString(Perevorot(N));не работает
//string newNS = Convert.ToString (newN);не работает
System.Console.WriteLine(N);
//System.Console.WriteLine(N.ToString("00000"));
System.Console.WriteLine(newN.ToString("00000"));
if (N == newN) System.Console.WriteLine("N - палиндром");
else System.Console.WriteLine("N - не палиндром");
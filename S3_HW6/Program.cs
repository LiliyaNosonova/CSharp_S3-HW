// 6. Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125


int N = new Random().Next(0, 9);
System.Console.WriteLine($"N = {N}");
int res = 0;
for (int i = 1; i <= N; i++)
{
    res = i * i * i;
    System.Console.Write($"{res}, ");
}



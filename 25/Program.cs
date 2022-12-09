// 25. Вывести на экран кубы чисел от 1 до N

int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=N)
{
    i=(int)Math.Pow(i,3);
    System.Console.Write($"{i} ");
    i=i+1;
}
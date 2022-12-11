// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int N,int min,int max)
{
int[] a=new int[N];
//Заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,200);
    return a;
}

void PrintArray(int[] a, int tab=5)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write("{0,"+tab+"}",a[i]);
}

int Solve(int[] a)
{
/*
//Обработка массива
int count=0;
for(int i=0;i<a.Length;i++)
    if(a[i]>=10 && a[i]<=99)
        count++;
*/
//foreach
int count=0;
foreach(int el in a)
{
if(el>=10 && el<=99)
        count++;
}
    return count;
}

//Создали массив
int M=123;
int[] a=RandomIntArray(M,0,200);
PrintArray(a,10);
//Обработка массива
System.Console.WriteLine($"\n{Solve(a)}");
﻿// 70. Показать натуральные числа от 1 до N, N задано

int i=1;
int N=10;
metka:
    System.Console.WriteLine(i);
    i++;
if (i<=N) goto metka;

/*
void Loop(int N, int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Loop(N;i+1);
    }
}

Loop(10,1);
*/
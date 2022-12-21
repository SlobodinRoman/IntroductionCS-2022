// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

string s=Console.ReadLine();
int n;
int.TryParse(s,out n);
System.Console.WriteLine(n);
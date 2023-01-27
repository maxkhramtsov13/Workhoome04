//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Random rnd = new Random();
long n = rnd.Next(10, 10000);
System.Console.WriteLine(n);
while ( n > 999 )
n = n / 10;
System.Console.WriteLine( n % 10 );
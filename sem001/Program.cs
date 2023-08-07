/*Console.WriteLine ("Введите число 1");
int num1 = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите число 2");
int num2 = int.Parse (Console.ReadLine ());
if (num1==num2*num2)
{
    Console.WriteLine (" Число 1 это квадрат числа 2");
}
else
{
    Console.WriteLine (" Число 1 это не квадрат числа 2");
}*/
/*Console.WriteLine ( num1==num2*num2 ? "Число 1 является квадратом числа 2" : "Число 1 не является квадратом числ)*/

Console.WriteLine ("Введите номер дня ");
int day = int.Parse(Console.ReadLine ());
if (day==1)
{
    Console.WriteLine ("Понедельник");
    return;
}
if (day==2)
{
    Console.WriteLine ("Вторник");
    return;
}
if (day==1)
{
    Console.WriteLine ("Среда");
    return;
}

if (day==4)
{
    Console.WriteLine ("Четверг");
    return;
}
if (day==5)
{
    Console.WriteLine ("Пятница");
    return;
}
if (day==6)
{
    Console.WriteLine ("Суббота");
    return;
}
if (day==7)
{
   Console.WriteLine ("Воскресенье");
   return;
}





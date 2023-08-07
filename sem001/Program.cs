Console.WriteLine ("Введите число 1");
int num1 = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите число 2");
int num2 = int.Parse (Console.ReadLine ());
/*if (num1==num2*num2)
{
    Console.WriteLine (" Число 1 это квадрат числа 2");
}
else
{
    Console.WriteLine (" Число 1 это не квадрат числа 2");
}*/
Console.WriteLine ( num1==num2*num2 ? "Число 1 является квадратом числа 2" : "Число 1 не является квадратом числа 2");


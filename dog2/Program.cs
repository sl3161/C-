int count = 0;
int b = 1;
double t = 0;
Console.WriteLine("введите расстояние между людьми");
double distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите скорость 1-го человека");
double v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите скорость 2-го человека");
double v2 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("введите скорость собаки");
double v_dog = Convert.ToDouble(Console.ReadLine ());
while (distance>1)
{
    if (b==1)
    {
       t = distance/(v_dog+v2);
       distance = distance - (v1+v2)*t;
       b=2;
    }
    if (b==2)
    {
        t = distance /(v_dog+v1);
        distance = distance - t*(v1+v2);
        b=1;
    }
    count++;
}
Console.Write ("Собака успеет пробежать между людьми -");
Console.WriteLine (count);

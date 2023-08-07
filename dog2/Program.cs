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
while (distance>0.001)
{
    if (b==1)
    {
       t = distance/(v_dog*1000+v2*1000);
       distance = distance - (v1*1000+v2*1000)*t;
       b=2;
    }
    if (b==2)
    {
        t = distance /(v_dog*1000+v1*1000);
        distance = distance - t*(v1*1000+v2*1000);
        b=1;
    }
    count=count+1;
}
Console.Write ("Собака успеет пробежать между людьми -");
Console.WriteLine (count);

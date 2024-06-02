using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задание №1
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //int summa = x + y;
            //Console.WriteLine($"{x}+{y}={summa}");
            //Console.ReadKey();


            ////Задание №2
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z = ");
            //int z = int.Parse(Console.ReadLine());
            //int summa = x + y + z;
            //Console.WriteLine($"{x}+{y}+{z}={summa}");
            //Console.ReadKey();


            ////Задание №3
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //double y = double.Parse(Console.ReadLine());
            //double proizv = x * y;
            //Console.WriteLine($"{x}*{y}={proizv}");
            //Console.ReadKey();


            ////Задание №4
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //double y = double.Parse(Console.ReadLine());
            //double delenie = x / y;
            //Console.WriteLine($"{x}/{y}={delenie}");
            //Console.ReadKey();


            ////Задание №5
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //int summa = a + b;
            //Console.WriteLine($"{a}+{b}={summa}={a}+{b}");
            //Console.WriteLine("Для продолжения нажмите любую клавишу...");
            //Console.ReadKey();


            ////Задание №6
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //int summa = a + b;
            //int otriz = a - b;
            //int proizv = a * b;
            //Console.Write($"a+b={a}+{b}={summa} \t");
            //Console.Write($"a-b={a}-{b}={otriz} \t");
            //Console.Write($"a*b={a}*{b}={proizv} \t");
            //Console.WriteLine("Для продолжения нажмите любую клавишу...");
            //Console.ReadKey();


            ////Задание №7
            //Console.Write("Как тебя зовут? ");
            //string name = Console.ReadLine();
            //Console.Write("Сколько тебе лет? ");
            //int age = int.Parse(Console.ReadLine());
            //int god = 2009;
            //Console.Write($"{name}, ты родился в {god - age} году.");
            //Console.ReadKey();


            ////Задание №8
            //Console.Write("Номинал купюры = ");
            //int money = int.Parse(Console.ReadLine());
            //Console.Write("Кол-во купюр = ");
            //int nomber = int.Parse(Console.ReadLine());
            //Console.Write("Сумма денег = ");
            //Console.Write($"{money * nomber}p.");
            //Console.ReadKey();



            ////Задание №9
            //Console.Write("Длина стороны = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("P квадрата = ");
            //Console.Write($"{4 * a}");
            //Console.ReadKey();


            ////Задание №10
            //Console.Write("Введите длину сторону а = ");
            //double lenga = double.Parse(Console.ReadLine());
            //Console.Write("Введите длину сторону а = ");
            //double lengb = double.Parse(Console.ReadLine());
            //double perim = 2 * (lenga + lengb);
            //Console.Write($"Периметр прямоугольника = {perim}");
            //Console.ReadKey();


            ////Задание №11
            //Console.Write("Введите радиус окружности = ");
            //double R = double.Parse(Console.ReadLine());
            //double L = 2 * 3.14 * R;
            //Console.WriteLine($"Длина окружности = {L}");
            //Console.ReadKey();


            //Задание №12
            //Console.Write("Объем флешки(ГБ)= ");
            //int V = int.Parse(Console.ReadLine());
            //int Z = V * 1000 / 820;
            //Console.WriteLine($"Вы сможете поместить на флешку {Z} раз");
            //Console.ReadKey();


            ////Задание №13
            //Console.Write("Введите двухзначное число: ");
            //int x = int.Parse(Console.ReadLine());
            //int y = x / 10;
            //int z = x / 10 % 10;
            //Console.WriteLine($"Первая цифра = {y}");
            //Console.WriteLine($"Первая цифра = {y}");
            //Console.ReadKey();
            ////2/2/2/2//2/2
            //Console.Write("Ваше двухзначное число: ");
            //int x = int.Parse(Console.ReadLine());
            //string y = x.ToString();
            //Console.WriteLine($"Первое цифра {y[0]}, Вторая цифра {y[1]}.");
            //Console.ReadKey();  


            ////Задание №14
            //Console.Write("x = "); //Console.WriteLine("");
            //int x = int.Parse(Console.ReadLine()); //Console.Read();
            //double y = 0;
            //if (x >= 0)
            //{
            //    y = Math.Sqrt(x) + 2 * Math.Sin(x);
            //}
            //else
            //{
            //    y = (6 - Math.Pow(x, 2));
            //}
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();


            ////ЗАДАЧА 16
            //Console.Write("Введите x = ");
            //int x = int.Parse(Console.ReadLine());
            //double z = 0;
            //if (x >= 0)
            //{
            //    z = 2 + 3 * Math.Sqrt(x);
            //}
            //else 
            //{
            //    z = 1 - 2 * Math.Pow(x, 2);
            //}
            //Console.WriteLine(z);
            //Console.ReadKey();


            ////ЗАДАЧА 17
            //double f = 0;
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //if (x <= -5) 
            //{
            //    f = Math.Sqrt(13 - x);
            //}
            //if (x >= -5 & x < 5)
            //{
            //    f = Math.Abs(4 * x - 5);
            //}
            //if (x >= 5)
            //{
            //    f = 3 * Math.Pow(x, 2) - 5 * x;
            //}
            //Console.WriteLine($"f = {f}");
            //Console.ReadKey();


            ////ЗАДАЧА 18
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine($"Полученное чилсо = {x + 1}");
            //}
            //else 
            //{ 
            //    Console.WriteLine($"Полученное чилсо = {x - 2}");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 19
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine($"Полученное чилсо = {x + 1}");
            //}
            //if (x < 0)
            //{
            //    Console.WriteLine($"Полученное чилсо = {x - 2}");
            //}
            //if (x == 0)
            //{
            //    Console.WriteLine($"Полученное чилсо = {x + 10}"); 
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 20
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine("Число положительное");
            //}
            //if (x < 0)
            //{
            //    Console.WriteLine("Число отрицательное");
            //}
            //if (x == 0)
            //{
            //    Console.WriteLine("Число нулевое");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 21
            //Console.Write("Введите сторону a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Введите сторону c = ");
            //int c = int.Parse(Console.ReadLine());
            //if (a == b && a == c)
            //{
            //    Console.WriteLine("Треугольник равностороний!");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не равностороний!");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 22
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //double y = 3;
            //if (3 % x == 0)
            //{
            //    Console.WriteLine("x является делителем числа 3");
            //}


            ////ЗАДАЧА 23
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int x = rnd.Next(-30, 30);
            //    if (x > 0)
            //    {
            //        Console.WriteLine($"{x} положительное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{x} отрицательное");
            //    }
            //    if (x == 0)
            //    {
            //        Console.WriteLine($"{x} нулевое");
            //    }
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 24
            //Random rnd = new Random();
            //for (int i = 0; i < 8; i++)
            //{
            //    int x = rnd.Next(-20, 30);
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine($"{x} четное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{x} не четное");
            //    }
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 25
            //Random rnd = new Random();
            //for(int i = 0; i < 10; i++)
            //{
            //    int x = rnd.Next(-20, 20);
            //    if(x > 0)
            //    {
            //        if(x % 2 == 0)
            //        {
            //            Console.WriteLine($"Положительное число {x} - является четным");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Положительное число {x} - является нечетным");
            //        }
            //    }
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 26
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //if (a == b)
            //{
            //    Console.WriteLine("Числа равны");
            //} else
            //{
            //    if (a > b)
            //    {
            //        Console.WriteLine($"Чилсо a = {a} является большем чем b = {b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Чилсо b = {b} является большем чем a = {a}");
            //    }
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 27
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1: Console.WriteLine("ПН"); break;
            //    case 2: Console.WriteLine("ВТ"); break;
            //    case 3: Console.WriteLine("СР"); break;
            //    case 4: Console.WriteLine("ЧТ"); break;
            //    case 5: Console.WriteLine("ПТ"); break;
            //    case 6: Console.WriteLine("СБ"); break;
            //    case 7: Console.WriteLine("ВС"); break;
            //    default: Console.WriteLine("ХЗ"); break;
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 28
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int x = rnd.Next(1, 100);
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine($"{x} четное число");
            //    }
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 29
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int x = rnd.Next(1, 100);
            //    if (x % 2 != 0)
            //    {
            //        Console.WriteLine($"{x} нечетное число");
            //    }
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 30
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Привет!");
            //}
            //Console.ReadKey();



            ////ЗАДАЧА 31
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());  
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Информатика");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 32
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 33
            //for (int i = 0; i < 18; i++)
            //{
            //    Console.Write("i ");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 34
            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 35
            //for (int i = 0; i < 18; i++)
            //{
            //    Console.Write("i ");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 36
            //for (int x = 1; x < 20; x+=2)
            //{
            //    int y = 5 * x - 2;
            //    Console.WriteLine(y);
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 37
            //for (int x = 1; x < 30; x += 3)
            //{
            //    int y = 4 * x - 5;
            //    Console.WriteLine(y);
            //}
            //Console.ReadKey();


            //ЗАДАЧА 38
            //for (int x = -5; x <= 5; x += 2) //y=5x^2-2x+1
            //{
            //    double y = 5 * Math.Pow(x, 2) - 2 * x + 1;
            //    Console.WriteLine($"x = {x}\t y = {y}");
            //}
            //Console.ReadKey();


            //ЗАДАЧА 39
            //for (int x= -9; x < 9;x += 3) //y = 4x² + 5x - 10 
            //{
            //    double y = 4 * Math.Pow(x, 2) + 5 * x - 10;
            //    Console.WriteLine($"x = {x}\t y = {y}");   
            //}
            //Console.ReadKey();


            //ЗАДАЧА 40
            //for (int i = 1; i < 12; i+=2)
            //if (i != 3)
            //{
            //        Console.WriteLine(i);
            //}
            //Console.ReadKey();  


            //ЗАДАЧА 41
            //for (int i = 4; i < 21; i+=4)
            //    {
            //        Console.WriteLine(i);
            //    }
            //Console.ReadKey();


            //ЗАДАЧА 42
            //int i = 1;
            //while (i < 12)
            //{
            //    if (i != 3)
            //    Console.WriteLine(i);
            //    i += 2;
            //}
            //Console.ReadKey();  


            //ЗАДАЧА 43
            //for (int x = 10; x <= 100; x++)
            //{
            //    if (x % 10 == 0)
            //        Console.WriteLine($"Числа кратные {x}");
            //}
            //int x = 10;
            //while (x <= 99)
            //{
            //    if (x % 10 == 0)
            //        Console.WriteLine($"{x}");
            //    x++;  // Итерация
            //}
            //Console.ReadKey();


            //ЗАДАЧА 44
            //for (int i = 100; i < 200; i++)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.ReadKey();


            //ЗАДАЧА 45
            //double x = 20.4;
            //for (int i = 2; i < 20; i++)
            //{
            //    double y = x * i;
            //    Console.WriteLine($"{i} товаров будут стоить: {y}");
            //}
            //Console.ReadKey();


            //ЗАДАЧА 46
            //for (int i = 0; i < 20;  i++)
            //{
            //    Console.Write("20 ");
            //}
            //Console.ReadKey();


            //ЗАДАЧА 47
            //Console.Write("Курс $ = ");
            //double x = double.Parse(Console.ReadLine());
            //for (int i = 1; i <= 20; i++)
            //{
            //    double y = x * i;
            //    Console.WriteLine($"{i} $ будут стоить: {y}, по курсу {x}");
            //}
            //Console.ReadKey();


            ////ЗАДАЧА 48
            //int s = 0;
            //for (int x = 0; x <= 1000; x++)
            //{
            //    if (x % 5 == 0)
            //        s = s + x; //s+=x;

            //}
            //Console.WriteLine($"{s}");
            //Console.ReadKey();


            //ЗАДАЧА 49
            //for (int i = 0; i < 10;  i++)
            //{
            //    Console.Write("10 ");
            //}
            //Console.ReadKey();


            //ЗАДАЧА 50
            //for (int x = 11; x <= 100; x++)
            //{
            //    if (x % 11 == 0)
            //        Console.WriteLine($"Числа кратные {x}");
            //}
            //Console.ReadKey();

            //int x = 10;
            //while (x <= 99)
            //{
            //    if (x % 11 == 0)
            //        Console.WriteLine($"{x}");
            //    x++;  // Итерация
            //}
            //Console.ReadKey();
        }
    }
}

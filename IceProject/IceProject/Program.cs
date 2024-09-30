using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Я создаю свой проект для закрепления знаний по изученному материалу в языке программирования C#. (29.09.24 19:14) - момент написания этого текста.
//Пожалуй, создам консольную игру про снайпер.

namespace IceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sniper Alpha = new Sniper();
            IFirst first = new Sniper();
            first.Action();
            ISecond second = new Sniper();
            second.Action(); 
            //Alpha.ProSdacha();     ////Сдавайтесь, тест интерфейса при одинаковом имени метода, но разном типе. 
            //Alpha.Sdacha();     ////Сдаюсь, тест интерфейса при одинаковом имени метода, но разном типе.
            Alpha.Shot();
            Sniper.tod = 3;
            Sniper.Info();
        }
    }
}

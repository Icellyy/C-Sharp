using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceProject
{
    class Sniper : ISdacha, IProSdaha, IFirst, ISecond
    {
        private int boolets = 5;
        private int allboolets = 30;
        private static double kills = 0;

        private byte minchange = 85;
        private byte maxchange = 100;

        private static int timeofday;

        public static int tod
        {
            get { return timeofday; }
            set { timeofday = value; }
        }


        private byte Change()
        {
            Random shot = new Random();
            byte Change = (byte)shot.Next(minchange, maxchange);
            return Change;
        }

        public void Reload()
        {
            if (allboolets != 0)
            {
                if (boolets == 0)
                {
                    Console.WriteLine("Перезарояжаюсь!");
                    boolets += 5;
                    allboolets -= 5;
                }
                else
                {
                    Console.WriteLine("Неа, у меня еще есть патроны)))");
                }
                Freedoom();
            }
            else
            {
                Console.WriteLine("Чёрт, у нас больше нет патронов...");
            }
        }

        public void Shot()
        {
            if (boolets != 0)
            {
                if (minchange < 100)
                {

                    Console.WriteLine("Вы задерживаете дыхание... \tВЫСТРЕЛ!");

                    boolets--;
                    allboolets--;

                    byte ChangeShot = Change();
                    if (ChangeShot < 90)
                    {
                        minchange++;
                        Console.WriteLine($"Мазила, кто тебе винтовку дал? \t{ChangeShot}");
                        Freedoom();
                    }
                    if (ChangeShot > 90 && ChangeShot < 95)
                    {
                        minchange++;
                        Console.WriteLine($"Молоддец, ты ранил его. \t{ChangeShot}");
                        kills += 0.5;
                        Info();
                        Freedoom();
                    }
                    if (ChangeShot > 95)
                    {
                        Console.WriteLine($"Точно в цель, противник мёртв! \t{ChangeShot}");
                        kills++;
                        Info();
                        Freedoom();
                    }
                }
                else
                {
                    Console.WriteLine("Думаю на сегодня хватит, ты и так в ударе)))");
                    Info();
                }
            }
            else
            {
                Reload();
            }
        }

        private void Freedoom()
        {
            bool continueShooting = true;

            while (continueShooting)
            {
                Console.WriteLine("\nСмогу ли Я? \t Да(1) / Нет(0)");

                if (byte.TryParse(Console.ReadLine(), out byte free))
                {
                    switch (free)
                    {
                        case 1:
                            if(allboolets != 0)
                            Console.WriteLine("\nДа, Я смогу!\n");
                            Shot();
                            break;

                        case 0:
                            Console.WriteLine("\nНет, пора уходить.\n");
                            continueShooting = false; // Остановка цикла
                            break;

                        default:
                            Console.WriteLine("Так, еще раз!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Так, еще раз!");
                }
            }
        }


        public static void Info()
        {
            Console.WriteLine($"Количество убийств: {kills}\t На часах {tod}");
        }

        public void Sdacha()
        {
            Console.WriteLine("Я сдаюсь!");
        }

        public void ProSdacha()
        {
            Console.WriteLine("Сдавайтесь!");
        }

        void IFirst.Action()
        {
            Console.WriteLine("1ый на связи!");
        }

        void ISecond.Action()
        {
            Console.WriteLine("2ой на связи!");
        }
    }
}

using System;

namespace gamestudent
{
    struct Student
    {
        public int golod;
        public int nastroenie;
        public int ucheba;
        public int money;
        public int sleep;
        public int health;
        public void Information()
        {
            Console.WriteLine($"Голод: {golod} Настроение: {nastroenie} Учеба: {ucheba} Деньги: {money} Сон: {sleep} Здоровье: {health} ");
            Console.ReadKey();
        }
        public void Eda()
        {
            Console.WriteLine("Что вы будете есть?" + "\n" + "1.Приготовить еду дома" + "\n" + "2.Заварить доширак" + "\n" + "3.Поесть в столовой" + "\n" + "4.Поесть в МакДональдсе" + "\n" + "5.Поесть в ресторане");
            string meal = Console.ReadLine();
            if (meal == "1")
            {
                golod = golod + 15;
                nastroenie = nastroenie + 5;
                ucheba = ucheba - 3;
                money = money - 200;
                sleep = sleep - 5;
                health = health + 15;
            }
            if (meal == "2")
            {
                golod = golod + 15;
                nastroenie = nastroenie + 10;
                ucheba = ucheba - 3;
                money = money - 44;
                sleep = sleep - 5;
                health = health - 10;
            }
            if (meal == "3")
            {
                golod = golod + 20;
                nastroenie = nastroenie + 10;
                ucheba = ucheba - 3;
                money = money - 400;
                sleep = sleep - 5;
                health = health + 15;
            }
            if (meal == "4")
            {
                golod = golod + 20;
                nastroenie = nastroenie + 20;
                ucheba = ucheba - 3;
                money = money - 500;
                sleep = sleep - 5;
                health = health - 10;
            }
            if (meal == "5")
            {
                golod = golod + 30;
                nastroenie = nastroenie + 30;
                ucheba = ucheba - 3;
                money = money - 2500;
                sleep = sleep - 5;
                health = health + 10;
            }
            Console.WriteLine("Вы поели!");
            Console.ReadKey();


        }
        public void Razvl()
        {
            Console.WriteLine("Что вы будете делать?" + "\n" + "1.Посмотреть мемы" + "\n" + "2.Выпить пиво" + "\n" + "3.Послушать музыку" + "\n" + "4.Сходить в кино" + "\n" + "5.Поиграть в Доту");
            string nastr = Console.ReadLine();
            if (nastr == "1")
            {
                golod = golod -3;
                nastroenie = nastroenie + 15;
                ucheba = ucheba - 3;
                sleep = sleep - 10;
            }
            if (nastr == "2")
            {
                golod = golod + 5;
                nastroenie = nastroenie + 15;
                ucheba = ucheba - 10;
                money = money - 200;
                sleep = sleep - 10;
                health = health - 10;
            }
            if (nastr == "3")
            {
                golod = golod + -1;
                nastroenie = nastroenie + +20;
                ucheba = ucheba - -10;
                sleep = sleep - 5;
            }
            if (nastr == "4")
            {
                golod = golod -5 ;
                nastroenie = nastroenie + 30;
                ucheba = ucheba - 5;
                money = money - 500;
                sleep = sleep - 10;
            }
            if (nastr == "5")
            {
                golod = golod + -20;
                nastroenie = nastroenie + 50;
                ucheba = ucheba - 40;
                sleep = sleep - 20;
                health = health -20;
            }
            Console.WriteLine("Ваше настроение поднялось!");
            Console.ReadKey();

        }
        public void Rabota()
        {
            Console.WriteLine("Что вы будете делать?" + "\n" + "1.Попросить денег у родителей" + "\n" + "2.Поработать промоутером" + "\n" + "3.Поработать грузчиком" + "\n" + "4.Поиграть на гитаре в переходе" + "\n" + "5.Поработать сборщиком");
            string rabo = Console.ReadLine();
            Random rnd = new Random();

            if (rabo == "1")
            {
                golod = golod -5;
                nastroenie = nastroenie -30;
                money = money + 2500;
            }
            if (rabo == "2")
            {
                golod = golod - 20;
                nastroenie = nastroenie - 10;
                ucheba = ucheba - 15;
                money = money + 1500;
                sleep = sleep - 15;
                health = health - 10;
            }
            if (rabo == "3")
            {
                golod = golod - 20;
                nastroenie = nastroenie - 15;
                ucheba = ucheba - 15;
                money = money + 2000;
                sleep = sleep - 15;
                health = health  - 20;
            }
            if (rabo == "4")
            {
                golod = golod - 15;
                nastroenie = nastroenie + 10;
                ucheba = ucheba - 15;
                money = rnd.Next(0,5000);
                sleep = sleep - 10;
                health = health - 5;
            }
            if (rabo == "5")
            {
                golod = golod - 20;
                nastroenie = nastroenie + 5;
                ucheba = ucheba - 15;
                money = money +3000;
                sleep = sleep - 10;
                health = health - 10;
            }
            Console.WriteLine("Вы заработали денег!");
            Console.ReadKey();
        }
        public void Ucheba()
        {
            Console.WriteLine("Что вы будете делать?" + "\n" + "1.Сходить на пары" + "\n" + "2.Сделать домашнее задание" + "\n" + "3.Пропустить пары" );
            string uche = Console.ReadLine();
            if (uche == "1")
            {
                golod = golod -10;
                nastroenie = nastroenie  -10;
                ucheba = ucheba + 20;
                sleep = sleep - 10;
            }
            if (uche == "2")
            {
                golod = golod - 5;
                nastroenie = nastroenie - 5;
                ucheba = ucheba + 15;
                sleep = sleep - 5;
            }
            if (uche == "3")
            {
                golod = golod -5;
                nastroenie = nastroenie + 20;
                ucheba = ucheba - 20;
                sleep = sleep - 5;
            }
            
            Console.WriteLine("Вы повлияли на свою успеваемость!");
            Console.ReadKey();

        }
        public void Son()
        {
            golod = golod - 5;
            nastroenie = nastroenie + 5;
            ucheba = ucheba - 3;
            sleep = sleep +50;
            health = health + 25;
            Console.WriteLine("Вы поспали!");
            Console.ReadKey();
        }
        public void Health()
        {
            Console.WriteLine("Что вы будете делать?" + "\n" + "1.Выпить витамины" + "\n" + "2.Позаниматься спортом" + "\n" + "3.Погулять на свежем воздухе" );
            string zdov = Console.ReadLine();
            if (zdov == "1")
            {
                golod = golod + 5;
                nastroenie = nastroenie + 5;
                ucheba = ucheba - 3;
                money = money - 500;
                health = health + 20;
            }
            if (zdov == "2")
            {
                golod = golod -3;
                nastroenie = nastroenie + 10;
                ucheba = ucheba - 3;
                sleep = sleep - 5;
                health = health + 20;
            }
            if (zdov == "3")
            {
                golod = golod - 3;
                nastroenie = nastroenie + 15;
                ucheba = ucheba - 3;
                sleep = sleep - 5;
                health = health + 15;
            }
           
            Console.WriteLine("Вы повысил здоровье!");
            Console.ReadKey();

        }

        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                Student ann = new Student();
                ann.golod = rnd.Next(40, 90);
                ann.nastroenie = rnd.Next(40, 90);
                ann.ucheba = rnd.Next(40, 90);
                ann.money = rnd.Next(1000, 5000);
                ann.sleep = rnd.Next(40, 90);
                ann.health = rnd.Next(40, 90);
                ann.Information();
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine("Что хотите сделать сейчас?" + "\n" + "1.Поесть" + "\n" + "2.Поднять настроение" + "\n" + "3.Поучиться" + "\n" + "4.Заработать денег" + "\n" + "5.Поспать" + "\n" + "6.Поднять здоровье");
                    string deystv = Console.ReadLine();
                    if (deystv == "1")
                    {
                        ann.Eda();
                        ann.Information();
                        if ((ann.golod<=0)|(ann.nastroenie<=0)|(ann.ucheba<=0)|(ann.money<=0)|(ann.sleep<=0)|(ann.health<=0))
                        {
                            Console.WriteLine("Вы проиграли!");
                            return;
                        }
                    }
                    if (deystv == "2")
                    {
                        ann.Razvl();
                        ann.Information();
                        if ((ann.golod <= 0) | (ann.nastroenie <= 0) | (ann.ucheba <= 0) | (ann.money <= 0) | (ann.sleep <= 0) | (ann.health <= 0))
                        {
                            Console.WriteLine("Вы проиграли!");
                            return;
                        }
                    }
                    if (deystv == "3")
                    {
                        ann.Ucheba();
                        ann.Information();
                        if ((ann.golod <= 0) | (ann.nastroenie <= 0) | (ann.ucheba <= 0) | (ann.money <= 0) | (ann.sleep <= 0) | (ann.health <= 0))
                        {
                            Console.WriteLine("Вы проиграли!");
                            return;
                        }
                    }
                    if (deystv == "4")
                    {
                        ann.Rabota();
                        ann.Information();
                        if ((ann.golod <= 0) | (ann.nastroenie <= 0) | (ann.ucheba <= 0) | (ann.money <= 0) | (ann.sleep <= 0) | (ann.health <= 0))
                        {
                            Console.WriteLine("Вы проиграли!");
                            return;
                        }
                    }
                    if (deystv == "5")
                    {
                        ann.Son();
                        ann.Information();
                        if ((ann.golod <= 0) | (ann.nastroenie <= 0) | (ann.ucheba <= 0) | (ann.money <= 0) | (ann.sleep <= 0) | (ann.health <= 0))
                        {
                            Console.WriteLine("Вы проиграли!");
                            return;
                        }
                    }
                    if (deystv == "6")
                    {
                        ann.Health();
                        ann.Information();
                        if ((ann.golod <= 0) | (ann.nastroenie <= 0) | (ann.ucheba <= 0) | (ann.money <= 0) | (ann.sleep <= 0) | (ann.health <= 0))
                        {
                            Console.WriteLine("Вы проиграли!");
                            return;
                        }
                    }
                }
                Console.WriteLine("Вы выиграли!");

            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Вас зовут" + " " + name);
            Console.WriteLine("Вспомнив своё имя вы решаете осмотеться вокруг.");
            Console.WriteLine("В помещении стоял странный запах, который, почему-то, не вызывал никаких подозрений.");
            Console.WriteLine("Вам на глаза попалась дверь, а рядом с ней до жути страшная статуя. ");
            Console.WriteLine("Статуя вызвала легкое чувство дежавю, впрочем вы быстро об этом забыли");
            Console.WriteLine("Помимо того что вы увидели, в комнате были еще некоторые вещи: вентиляция,ящик, тумбочка, кровать");
            Console.WriteLine("Что вы собираетесь делать?");
            int art = 0;
            bool lockpick = false;
            int bed = 0;
            bool key = false;
            int punch = 0;
            int table = 0;
        Calibri:
            Console.WriteLine(
                "1 - Подойти и осмотреть дверь" +
                "2 - Подойти и осмотреть статую." +
                "3 - Осмотреть тумбочку " +
                "4 - Осмотреть вентиляцию." +
                "5 - Осмотреть ящик." +
                "6 - заглянуть/осмотреть кровать.");
            string action = Console.ReadLine();
            if (action == "1")
            {
                if (lockpick == false)
                {
                    Console.WriteLine("Вы подходите к двери она оказывается закрытой.");
                    goto Calibri;
                }
                else
                {
                    Console.WriteLine(name + " " + "вставляет отмычку в дверь." +
                        "спустя время замок в двери издает шелчек" +  " " +
                        "означающий, что дверь открыта.");
                    Console.WriteLine("ВЫ СБЕЖАЛИ!!!");
                    Console.Read(); // Оставляет окно открытым
                }
            }

            else if (action == "2" )
            {
                if (art == 3 & key == false)
                {
                    Console.WriteLine(name + " " + "вставляете все артефакты на места," +
                    "статуя открывается вы видете ключ.");
                    key = true;
                    goto Calibri;
                }
                else
                {

                    Console.WriteLine("Вы осматриваете статую." + " " + name + " "
                         + " понимает что вам надо три артефакта.");
                    goto Calibri;
                }
            }
            else if (action == "3")
            {
                if (table == 0)
                {
                    Console.WriteLine(name + " " + " осматривает тумбочку.");
                    Console.WriteLine(" Вы нашли артефакт.");
                    table = 1;
                    art = art + 1;
                    goto Calibri;
                }
                else
                {
                    Console.WriteLine("Вы уже осматривали тумбочку.");
                    goto Calibri;
                }
            }
            else if (action == "4")
            {

            Cheakpoint:
                if (punch == 3)
                { Console.WriteLine("Вентиляция сломалась, " +
                    "вы забираете артефакт.");
                    art = art + 1;
                    goto Calibri;
                }
                else
                {
                    Console.WriteLine("Вы видете старую, хлипкую вентиляцую," +
                        " попробовать ее открыть?" +
                        " Да/Нет");
                    string script = Console.ReadLine(); 
                    if (script == "да")
                    {
                        Console.WriteLine("Вы пытаетесь сломать вентиляцию.");
                        punch++;
                        goto Cheakpoint;
                    }
                    else
                    {
                        goto Calibri;
                    }
                    
                }
            }
            else if (action == "5")
            {
                if (key == true)
                {
                    Console.WriteLine("Вы открываете ящик," +
                        " внутри него вы находите отмычку.");
                    lockpick = true;
                    goto Calibri;
                }
                else
                {
                    Console.WriteLine(name + "Осматривает ящик," +
                        " видит замочную скажину." +
                        "Вы вернулись назад");
                    goto Calibri;
                }
            }
            else if (action == "6")
            {
                if (bed == 0)
                {
                    Console.WriteLine("Вы заглядываете под кровать и находите артефакт.");
                    art = art + 1; 
                    goto Calibri;
                }
                else
                {
                    Console.WriteLine("Ничего нового не появилось, " +
                        "xто я тут забыл?");
                    goto Calibri;
                }
            }
            else //Если выбрано число не из представленных
            {
                Console.WriteLine("вы задумались о смысле жизни?");
                goto Calibri;
            }

        }
    }
}

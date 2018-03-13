using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class FridgeEmulator
    {
        static void Main(string[] args)
        {
            Fridge fr = new Fridge();
            fr.status();
            bool end = false;
            string command, number;
            do
            {
                Console.WriteLine((fr.On ? "Выключить" : "Включить") + " холодильник - нажмите " + ((fr.On) ? "2" : "1"));
                Console.WriteLine((fr.Opened ? "Закрыть" : "Открыть") + " холодильник - нажмите " + (fr.Opened ? "4" : "3"));
                Console.WriteLine((fr.Full ? "Опустошить" : "Наполнить") + " хололдильник - нажмите " + (fr.Full ? "6" : "5"));
                Console.WriteLine("Изменить режим охлаждения - нажмите 7");
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            fr.turnOn();
                            break;
                        case 2:
                            fr.turnOff();
                            break;
                        case 3:
                            fr.open();
                            break;
                        case 4:
                            fr.close();
                            break;
                        case 5:
                            fr.open();
                            fr.fill();
                            fr.close();
                            break;
                        case 6:
                            fr.open();
                            fr.empty();
                            fr.close();
                            break;
                        case 7:
                            Console.WriteLine("Режим 'economy' - введите 1 \nРежим 'cold' - введите 2 \nРежим 'supercold' - введите 3");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    fr.changeMode(Fridge.mode.economy);
                                    break;
                                case 2:
                                    fr.changeMode(Fridge.mode.cold);
                                    break;
                                case 3:
                                    fr.changeMode(Fridge.mode.supercold);
                                    break;
                            }
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Продолжить - нажмите 1       Закончить - нажмите 2");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            end = false;
                            break;
                        case 2:
                            end = true;
                            break;
                        default:
                            Console.WriteLine("Нет такого варианта");
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ошибка. Неверный формат ввода");
                }
                finally { fr.status(); }
                
            } while (!end);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Fridge
    {
        bool on;

        public bool On{ get { return on; } }

        bool lightOn;
        public bool LightOn { get { return lightOn; } }
        bool opened;
        public bool Opened { get { return opened; } }
        bool full;
        public bool Full { get { return full; } }
        public enum mode { economy, cold, supercold };
        string currMode;

        public Fridge()
        {
            on = false;
            lightOn = false;
            opened = false;
            full = false;
            currMode = mode.cold.ToString();
        }

        public void status()
        {
            Console.WriteLine("Текущее состояние холодильника: ");
            Console.WriteLine("Включен: " + on.ToString());
            Console.WriteLine("Свет включён: " + lightOn.ToString());
            Console.WriteLine("Открыт: " + opened.ToString());
            Console.WriteLine("Полный: " + full.ToString());
            Console.WriteLine("Режим охлаждения: " + currMode);
            Console.WriteLine();
        }

        public void turnOn()
        {
            on = true;
            if (opened)
                lightOn = true;
            status();
        }
        public void turnOff()
        {
            on = false;
            lightOn = false;
            status();
        }

        public void open()
        {
            opened = true;
            if (on)
                lightOn = true;
            status();
        }
        public void close()
        {
            opened = false;
            lightOn = false;
            status();
        }

        public void fill()
        {
            full = true;
            status();
        }
        public void empty()
        {
            full = false;
            status();
        }

        public void changeMode(mode m)
        {
            currMode = m.ToString();
            status();
        }
    }
}

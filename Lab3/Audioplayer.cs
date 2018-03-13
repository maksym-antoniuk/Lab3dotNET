using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Audioplayer
    {
        private int volume;

        public Audioplayer() { volume = 0; }

        public int getVolume() { return volume; }

        public void setVolume(int volume) { if (volume >= 0 && volume <= 100) this.volume = volume; }
    }
}

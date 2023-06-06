using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class CoolDown
    {
        private int Interval;
        private int time = 0;
        private int Ltime = -10000;
        public CoolDown(int interval)
        {
            Interval = interval;
        }

        public void Update()
        {
            time++;
        }

        public bool Start()
        {
            if (time - Ltime > Interval)
            {
                Ltime = time;
                return true;
            }
            else return false;
        }

        public int Remaining()
        {
            return Interval - (time - Ltime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTraffic
{
    internal class Car
    {
        /*        private int speed;
                private int size;
        */
        /*public int Speed
        {
            get { return speed; }
        }

        public int Size
        {
            get { return size; }
        }*/

        public int speed;
        public int size;
        public int start_x;
        public int start_y;
        public int cur_x;
        public int cur_y;

        public Car()
        {
            this.speed = new Random().Next(30, 60);
        }

        public Car(int size_num)
        {
            this.size = size_num;
            this.speed = new Random().Next(0, 30);
        }

        public Car(int speed_num, int size_num)
        {
            this.speed = speed_num;
            this.size = size_num;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public abstract class Likovi:Sprite
    {
        protected int brzina;
        public int Brzina
        {
            get { return brzina; }
            set { brzina = value; }
        }
        public Likovi(string path, int x, int y, int speed) : base(path, x, y)
        {
            this.brzina = speed;
        }
    }
    public class Gonzales : Likovi
    {
        protected int energija;
        public int Energija
        {
            get { return energija; }
            set
            {
                if (value < 0)
                {
                    throw (new ArgumentException());
                }else { energija = value; }
            }
        }
        public Gonzales(string path, int x, int y, int en) : base(path, x, y, 15)
        {
            this.energija = en;
        }
    }
    public class Cheese : Likovi
    {
        public Cheese(string path, int x, int y) : base(path, x, y, 5)
        {

        }
    }
    public class Fridge : Likovi
    {
        public Fridge(string path, int x, int y) : base(path, x, y, 0)
        {

        }
    }
    public class Knife : Likovi
    {
        public Knife(string path, int x, int y) : base(path, x, y, 5)
        {

        }
    }
    public class Microwave : Likovi
    {
        public Microwave(string path, int x, int y) : base(path, x, y, 0)
        {

        }
    }
}

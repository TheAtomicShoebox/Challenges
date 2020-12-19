using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneChallenges
{
    public abstract class Phone
    {
        public string ID { get; set; }
        public bool BluetoothCapable { get; set; }
        public string OS { get; set; }
        public int Resolution { get; set; }
        public int Height { get; set; }

        public virtual int OnResize()
        {
            return Resolution * Height;
        }
    }

    public class Samsung : Phone
    {

    }

    public class Apple : Phone
    {
        public bool IsBad { get; set; } = true;
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Youtube
{
    internal class Subscriber
    {
        public string Name { get; set; }

        public void notify(Channel channel , Video video)
        {
            Console.WriteLine($"Channel : {channel.Title} is add Video :{video} ya {Name}");
        }

        public override string ToString()
        {
            return $"subsciber {Name}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Fifa
{
    internal class Coach
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public void Order(Ball ball)
        {
            Console.WriteLine($"Player {Name} is running ... at {ball}");
        }

        public override string ToString()
        {
            return $"Player Name : {Name} , Team Name : {TeamName}";
        }
    }
}

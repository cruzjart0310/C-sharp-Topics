using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Deconstruct
{
    public class ExampleDeconstruct
    {
        public void Desconstruct()
        {
            var robot = new Robot()
            {
                Name = "Robert",
                HasWheell = true,
                SensorCount = 5
            };

            var (a, b, c) = robot.GetStats();
            var (x, y, _) = robot.GetStats();

            Console.WriteLine($"Name: {a} - HasWheell:{b} - SensorCount:{c}");
        }
    }

    public class Robot
    {
        public string Name { get; set; }
        public bool HasWheell { get; set; }
        public int SensorCount { get; set; }

        public (string, bool, int) GetStats()
        {
            return (Name, HasWheell, SensorCount);
        }
    }
}

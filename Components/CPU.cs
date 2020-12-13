using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class CPU : AbstractComponent
    {
        public CPU()
        {
            Name = "CPU";
        }

        public static List<CPU> cpu = new List<CPU>
        {
            new CPU { Name = "2cores" },
            new CPU { Name = "4cores" },
            new CPU { Name = "8cores" }
        };

        public static List<CPU> GetCPU()
        {
            return cpu;
        }
    }
}

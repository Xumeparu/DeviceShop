using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class RAM : AbstractComponent
    {
        public RAM()
        {
            Name = "RAM";
        }

        public static List<RAM> ram = new List<RAM>
        {
            new RAM { Name = "-" },
            new RAM { Name = "2Gb" },
            new RAM { Name = "4Gb" },
            new RAM { Name = "8Gb" },
            new RAM { Name = "16Gb" }
        };

        public static List<RAM> GetRAM()
        {
            return ram;
        }
    }
}

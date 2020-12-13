using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class ROM : AbstractComponent
    {
        public ROM()
        {
            Name = "ROM";
        }

        public static List<ROM> rom = new List<ROM>
        {
            new ROM { Name = "-" },
            new ROM { Name = "128Gb" },
            new ROM { Name = "320Gb" },
            new ROM { Name = "512Gb" },
            new ROM { Name = "1Tb" }
        };

        public static List<ROM> GetROM()
        {
            return rom;
        }
    }
}

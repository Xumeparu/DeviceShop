using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class Display : AbstractComponent
    {
        public Display()
        {
            Name = "Display";
        }

        public static List<Display> display = new List<Display>
        {
            new Display { Name = "-" },
            new Display { Name = "HD" },
            new Display { Name = "FullHD" },
            new Display { Name = "UltraHD" }
        };

        public static List<Display> GetDisplay()
        {
            return display;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class Mouse : AbstractComponent
    {
        public Mouse()
        {
            Name = "Mouse";
        }

        public static List<Mouse> mouse = new List<Mouse>
        {
            new Mouse { Name = "-" },
            new Mouse { Name = "2-button" }
        };

        public static List<Mouse> GetMouse()
        {
            return mouse;
        }
    }
}

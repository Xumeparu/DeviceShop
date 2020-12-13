using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class TouchPad : AbstractComponent
    {
        public TouchPad()
        {
            Name = "TouchPad";
        }

        public static List<TouchPad> touchpad = new List<TouchPad>
        {
            new TouchPad { Name = "-" },
            new TouchPad { Name = "1-button" },
            new TouchPad { Name = "2-button" }
        };

        public static List<TouchPad> GetTouchPad()
        {
            return touchpad;
        }
    }
}

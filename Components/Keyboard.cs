using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Components
{
    public class Keyboard : AbstractComponent
    {
        public Keyboard()
        {
            Name = "Keyboard";
        }

        public static List<Keyboard> keyboard = new List<Keyboard>
        {
            new Keyboard { Name = "-" },
            new Keyboard { Name = "101" },
            new Keyboard { Name = "108" }
        };

        public static List<Keyboard> GetKeyboard()
        {
            return keyboard;
        }
    }
}

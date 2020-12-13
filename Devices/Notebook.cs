using DeviceShop.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Devices
{
    public class Notebook : AbstractDevice
    {
        public Notebook()
        {
            Name = "Notebook";
        }

        public override AbstractDevice Clone()
        {
            return new Notebook();
        }

        public override void GetDeviceInformation()
        {
            Console.WriteLine($"Components of {Name}:\n" +
                $" - Keyboard: {keyboard[2].Name}\n" +
                $" - Display: {display[2].Name}\n" +
                $" - Touchpad: {touchpad[1].Name}\n" +
                $" - CPU: {cpu[0].Name}\n" +
                $" - RAM: {ram[3].Name}\n" +
                $" - ROM: {rom[3].Name}");
        }
    }
}

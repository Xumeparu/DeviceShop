using DeviceShop.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Devices
{
    public class Laptop : AbstractDevice
    {
        public Laptop()
        {
            Name = "Laptop";
        }

        public override AbstractDevice Clone()
        {
            return new Laptop();
        }

        public override void GetDeviceInformation()
        {
            Console.WriteLine($"Components of {Name}:\n" +
                $" - Keyboard: {keyboard[1].Name}\n" +
                $" - Display: {display[1].Name}\n" +
                $" - Touchpad: {touchpad[2].Name}\n" +
                $" - CPU: {cpu[0].Name}\n" +
                $" - RAM: {ram[2].Name}\n" +
                $" - ROM: {rom[2].Name}");
        }
    }
}

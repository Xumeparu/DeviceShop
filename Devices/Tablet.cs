using DeviceShop.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Devices
{
    public class Tablet : AbstractDevice
    {
        public Tablet()
        {
            Name = "Tablet";
        }

        public override AbstractDevice Clone()
        {
            return new Tablet();
        }

        public override void GetDeviceInformation()
        {
            Console.WriteLine($"Components of {Name}:\n" +
                $" - Display: {display[3].Name}\n" +
                $" - CPU: {cpu[2].Name}\n" +
                $" - RAM: {ram[1].Name}\n" +
                $" - ROM: {rom[1].Name}");
        }
    }
}

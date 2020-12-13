using DeviceShop.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop.Devices
{
    public class Desktop : AbstractDevice
    {
        public Desktop()
        {
            Name = "Desktop";
        }

        public override AbstractDevice Clone()
        {
            return new Desktop();
        }

        public override void GetDeviceInformation()
        {
            Console.WriteLine($"Components of {Name}:\n" +
                $" - Mouse: {mouse[1].Name}\n" +
                $" - CPU: {cpu[1].Name}\n" +
                $" - RAM: {ram[4].Name}\n" +
                $" - ROM: {rom[4].Name}");
        }
    }
}

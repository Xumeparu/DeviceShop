using DeviceShop.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceShop
{
    public class Shop
    {
        private Laptop laptop = new Laptop();
        private Desktop desktop = new Desktop();
        private Notebook notebook = new Notebook();
        private Tablet tablet = new Tablet();

        public AbstractDevice GetDevice(string deviceName)
        {
            switch (deviceName)
            {
                case "Laptop":
                    return laptop.Clone();
                case "Desktop":
                    return desktop.Clone();
                case "Notebook":
                    return notebook.Clone();
                case "Tablet":
                    return tablet.Clone();
                default:
                    throw new ArgumentException("Unfortunately, our shop does not have this device " +
                                                "or you entered an incorrect name");
            }
        }
    }
}

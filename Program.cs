using DeviceShop.Devices;
using System;

namespace DeviceShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Console.Write("Enter a device name, please: ");
            string deviceName = Console.ReadLine();

            Console.WriteLine();

            AbstractDevice device = shop.GetDevice(deviceName);
            device.GetDeviceInformation();

            Console.ReadKey();
        }
    }
}

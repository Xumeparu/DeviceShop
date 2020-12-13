using System;
using System.Collections.Generic;
using System.Text;
using DeviceShop.Components;

namespace DeviceShop.Devices
{
    public abstract class AbstractDevice
    {
        protected string Name { get; set; }

        public List<Keyboard> keyboard = Keyboard.GetKeyboard();
        public List<Display> display = Display.GetDisplay();
        public List<Mouse> mouse = Mouse.GetMouse();
        public List<TouchPad> touchpad = TouchPad.GetTouchPad();
        public List<CPU> cpu = CPU.GetCPU();
        public List<RAM> ram = RAM.GetRAM();
        public List<ROM> rom = ROM.GetROM();

        public abstract AbstractDevice Clone();
        
        public virtual void GetDeviceInformation()
        {
            Console.WriteLine($"Components of {Name}:\n" +
                $" - Keyboard: {keyboard[0].Name}\n" +
                $" - Display: {display[0].Name}\n" +
                $" - Mouse: {mouse[0].Name}\n" +
                $" - Touchpad: {touchpad[0].Name}\n" +
                $" - CPU: {cpu[0].Name}\n" +
                $" - RAM: {ram[0].Name}\n" +
                $" - ROM: {rom[0].Name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer
    {
        // changed all properties to public for testing
        public string Manufacturer { get; set; }
        public int MemoryAmountGB { get; set; }
        public string OS { get; set; }
        public bool IsOn { get; set; }

        // set manufacturer, memory, and oS with constructor,
        // give IsOn a default value in contructor
        public Computer(string manufacturer, int memory, string oS)
        {
            Manufacturer = manufacturer;
            MemoryAmountGB = memory;
            OS = oS;
            // all computer will be powered off by default
            IsOn = false;
        }

        public string PowerOnOff()
        {
            // toggle IsOn property
            // with if statement
            /*if(IsOn) IsOn = false;
            else IsOn = true;*/
            // set IsOn to be the opposite of itself
            IsOn = !IsOn;
            // print whether or not computer is on AFTER toggling
            // the isOn property
            if (IsOn) return "Powered on!";
            else return "Powered off...";
        }

        public string GetInfo()
        {
            return $"Manufacturer: {Manufacturer}\n" +
                $"Memory Amount: {MemoryAmountGB}gb\n" +
                $"OS: {OS}\n" +
                $"Power Status: {IsOn}\n";
        }


    }
}

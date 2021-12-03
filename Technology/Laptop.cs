using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    // Laptop is a child class of Computer, so it needs to inherit
    // the Computer class along with its constructor
    public class Laptop : Computer
    {
        public bool HasNumPad { get; set; }

        // since we are inherting from the Computer class,
        // we need to pass all the necessary values into the 
        // constructor defined in the Computer class
        // we pass the paramters from laptop's constructor into base so that 
        // the values of all the inheritted properties get set as they are defined in
        // Computer's constructor
        public Laptop(string manufacturer, int memory, string oS, bool hasNumPad) : base(manufacturer, memory, oS)
        {
            // how we call the parent class' constructor in JS
            // super(manufacturer, memory, oS);
            HasNumPad = hasNumPad;
        }

        public void UpdateMemoryAmount(int newMemory)
        {
            MemoryAmountGB += newMemory;
        }
    }
}

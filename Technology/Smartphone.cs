using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Smartphone : Computer
    {
        public bool HasHeadphoneJack { get; set; }

        public Smartphone(string manufacturer, int memory, string oS, bool hasHeadphone) : base(manufacturer, memory, oS)
        {
            HasHeadphoneJack = hasHeadphone;
        }

        public string IsPhoneGood()
        {
            if (HasHeadphoneJack)
            {
                return "Nice! This is a good, useful smartphone. :)";
            }
            else
            {
                return "Bleh! Whyyyyyyy... please Apple?";
            }
        }
    }
}

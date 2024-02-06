﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand):base(isOn, brand)
        {

        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                Console.WriteLine("You need to turn it on first");
            }
        }

    }
}

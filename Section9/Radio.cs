using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    //Child class
    internal class Radio : ElectricalDevice
    {
        
        public Radio(bool isOn, string brand):base(isOn, brand)
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

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first!");
            }
        }

    }
}

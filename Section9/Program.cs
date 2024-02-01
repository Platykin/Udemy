using Section9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(true, "LG");

            TV myTV = new TV(false, "Pamonha");

            myRadio.ListenRadio();

            myTV.SwitchOn();
        }
    }
}

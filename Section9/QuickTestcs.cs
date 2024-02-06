using Section9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Timers;

namespace Section9
{
    class QuickTestcs
    {
        static System.Timers.Timer reloj;

        private static void SetTimer()
        {
            reloj = new System.Timers.Timer(1234);

            reloj.Elapsed += TempoVoa;
            reloj.AutoReset = true;
            reloj.Enabled = true;            
        }

        private static void TempoVoa(object? source, ElapsedEventArgs e)
        {
            Console.WriteLine("O tempo voa, irmão. Sabe que hora são? São {0:HH:mm:ss:fff}", e.SignalTime);
        }




    }


}

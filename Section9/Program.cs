﻿using Section9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Timers;



namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            #region
            //Radio myRadio = new Radio(true, "LG");

            //TV myTV = new TV(false, "Pamonha");

            //myRadio.ListenRadio();

            //myTV.SwitchOn();

            //myTV.WatchTV();

            //Dog tonha = new Dog("Tonha", 9);

            //tonha.Play();
            //tonha.Eat();
            //tonha.MakeSound();
            //Console.WriteLine($"{tonha.name} tem {tonha.age} aninhos");
            //Post post1 = new Post("Valeu gurizada", true, "Irgo");
            //Console.WriteLine(post1.ToString());

            //ImagePost imagePost1 = new ImagePost("Oia meu pisante", "Silvo", "https://images.com/shoes", true);
            //Console.WriteLine(imagePost1.ToString());

            //VideoPost videoPost1 = new VideoPost("Cute bear rolling on his own shit", "Dumb cubs","https://www.yourtubes.com/SF81RSDAgdhkafe62dv342", 9.15);
            //Console.WriteLine(videoPost1.ToString());

            //Console.WriteLine("Press any key to stop the video");
            //videoPost1.Play();
            //Console.ReadLine();
            //videoPost1.Stop();
            #endregion

            Ticket ticket1 = new Ticket(2);
            Ticket ticket2 = new Ticket(3);
            

        }
    }
}

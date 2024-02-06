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
            #endregion

            Post post1 = new Post("Valeu gurizada", true, "Irgo");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Oia meu pisante", "Silvo", "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

           



        }
    }
}

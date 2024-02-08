using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Timers;

namespace Section9
{

    class VideoPost : Post
    {
        System.Threading.Timer timer;

        protected string VideoURL { get; set; }
        public double LengthSeconds { get; set; }

        protected bool IsPlaying { get; set; }

        public static double CurrentDuration { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername,string videoURL, double length)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = base.IsPublic;
            this.VideoURL = videoURL;
            LengthSeconds = length;
            IsPlaying = false;
            CurrentDuration = 0;
        }

        public void Play()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Playing");
                timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(object o) 
        {
            if(CurrentDuration < LengthSeconds)
            {
                CurrentDuration++;
                Console.WriteLine("Video at {0}", CurrentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }




        }

        public void Stop()
        {
            if(IsPlaying) 
            { 
                IsPlaying = false;  
            Console.WriteLine("Stopped at {0}", CurrentDuration);
            CurrentDuration = 0;
            timer.Dispose();
            }


        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.VideoURL, this.SendByUsername);
        }


    }
}

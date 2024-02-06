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
        private static System.Timers.Timer relooj;

        public string VideoURL { get; set; }
        public static double LengthSeconds { get; set; }

        public bool IsPlaying { get; set; }

        public static double StopedAt { get; set; }

        public VideoPost(string title, string videoURL, double length)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = base.SendByUsername;
            this.IsPublic = base.IsPublic;
            VideoURL = videoURL;
            LengthSeconds = length;
            IsPlaying = false;
            StopedAt = 0;
        }

        public static void Play()
        {
            relooj = new System.Timers.Timer(1000);
            relooj.Elapsed += VideoTimer;
            relooj.Start();
            relooj.AutoReset = true;
        }

        private static void VideoTimer(object? sender, ElapsedEventArgs e)
        {
            if (e.SignalTime.Second < LengthSeconds)
            {
                Console.WriteLine($"{e.SignalTime.Minute}:{e.SignalTime.Second}");
            }
            else
            {
                relooj.Stop();
                Console.WriteLine("Video ended!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.VideoURL, this.SendByUsername);
        }


    }
}

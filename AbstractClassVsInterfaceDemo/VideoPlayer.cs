﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterfaceDemo
{
    public class VideoPlayer : IMediaPlayer
    {
        public void Pause()
        {
            // Pause video logic
            Console.WriteLine("Video paused");
        }

        public void Play()
        {
            // Play video logic
            Console.WriteLine("Playing video");
        }

        public void Stop()
        {
            // Stop video logic
            Console.WriteLine("Video stopped");

            // You can have other classes implementing IMediaPlayer for different types of media.
        }
    }
}

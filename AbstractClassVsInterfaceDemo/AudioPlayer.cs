using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterfaceDemo
{
    public class AudioPlayer : IMediaPlayer
    {
        public void Pause()
        {
            // Pause audio logic
            Console.WriteLine("Music paused");
        }

        public void Play()
        {
            // Play audio logic
            Console.WriteLine("Playing music");
        }

        public void Stop()
        {
            // Stop audio logic
            Console.WriteLine("Music stopped");
        }
    }
}

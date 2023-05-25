using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterfaceDemo
{
    public interface IMediaPlayer
    {
        //Interfaces are completely abstract
        public void Play();
        public void Stop();
        public void Pause();
    }
}

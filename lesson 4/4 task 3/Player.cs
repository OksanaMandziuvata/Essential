using System;

namespace Task_3
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Playback started.");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Playback paused.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playback stopped.");
        }

        public void Record()
        {
            Console.WriteLine("Recording started.");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recording paused.");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recording stopped.");
        }
    }
}

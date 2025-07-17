using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IPlayable playable = player;
            IRecordable recordable = player;

            Console.WriteLine("Playing:");
            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine("\nRecording:");
            recordable.Record();
            recordable.Pause();
            recordable.Stop();

            Console.ReadKey();
        }
    }
}

using System;

namespace Task_2
{
    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
                throw new ArgumentException("ClassRoom must contain 2 to 4 pupils.");

            this.pupils = pupils;
        }

        public void ShowPupilActivities()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine("Pupil #" + (i + 1) + ":");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }
}

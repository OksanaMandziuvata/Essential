using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new ExcellentPupil();
            Pupil p2 = new GoodPupil();
            Pupil p3 = new BadPupil();

            ClassRoom classRoom = new ClassRoom(p1, p2, p3);
            classRoom.ShowPupilActivities();
        }
    }
}

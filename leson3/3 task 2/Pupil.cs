using System;

namespace Task_2
{
    class Pupil
    {
        public virtual void Study() { Console.WriteLine("Pupil studies."); }
        public virtual void Read() { Console.WriteLine("Pupil reads."); }
        public virtual void Write() { Console.WriteLine("Pupil writes."); }
        public virtual void Relax() { Console.WriteLine("Pupil relaxes."); }
    }

    class ExcellentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Excellent pupil studies excellently."); }
        public override void Read() { Console.WriteLine("Excellent pupil reads a lot."); }
        public override void Write() { Console.WriteLine("Excellent pupil writes neatly."); }
        public override void Relax() { Console.WriteLine("Excellent pupil relaxes rarely."); }
    }

    class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Good pupil studies well."); }
        public override void Read() { Console.WriteLine("Good pupil reads regularly."); }
        public override void Write() { Console.WriteLine("Good pupil writes well."); }
        public override void Relax() { Console.WriteLine("Good pupil relaxes sometimes."); }
    }

    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Bad pupil studies poorly."); }
        public override void Read() { Console.WriteLine("Bad pupil reads rarely."); }
        public override void Write() { Console.WriteLine("Bad pupil writes badly."); }
        public override void Relax() { Console.WriteLine("Bad pupil relaxes all the time."); }
    }
}

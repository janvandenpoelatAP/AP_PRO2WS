using System;

namespace OplossingDiOefeningSamurai
{
    public class AutomaticTrigger : ITrigger
    {
        public void Pull()
        {
            Console.WriteLine("Pulling the automatic trigger");
        }
    }
}

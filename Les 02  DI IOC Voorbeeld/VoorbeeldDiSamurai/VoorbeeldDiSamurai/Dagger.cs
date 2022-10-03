using System;

namespace VoorbeeldDiSamurai
{
    public class Dagger : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Stab {target}  to death");
        }
    }
}

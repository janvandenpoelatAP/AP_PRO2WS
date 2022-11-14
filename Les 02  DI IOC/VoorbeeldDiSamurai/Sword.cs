using System;

namespace VoorbeeldDiSamurai
{
    public class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Chopped {target} clean in half");
        }
    }
}

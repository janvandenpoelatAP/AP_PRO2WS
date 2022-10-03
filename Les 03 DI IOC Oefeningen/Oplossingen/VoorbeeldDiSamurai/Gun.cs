using System;

namespace OplossingDiOefeningSamurai
{
    public class Gun : IWeapon
    {
        private readonly ITrigger _trigger;
        
		public Gun(ITrigger trigger)
        {
            _trigger = trigger;
        }

        public void Hit(string target)
        {
            Console.WriteLine($"Shooting{target}");
            _trigger.Pull();
        }
    }
}

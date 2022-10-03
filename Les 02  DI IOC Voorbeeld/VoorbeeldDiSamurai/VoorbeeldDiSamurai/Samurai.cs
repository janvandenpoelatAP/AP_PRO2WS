namespace VoorbeeldDiSamurai
{
    public class Samurai
    {
        private readonly IWeapon[] _weapons;

        public Samurai(IWeapon[] weapons)
        {
            _weapons = weapons;
        }

        public void Attack(string target)
        {
            foreach (var weapon in _weapons)
            {
                weapon.Hit(target);
            }
        }
    }
}

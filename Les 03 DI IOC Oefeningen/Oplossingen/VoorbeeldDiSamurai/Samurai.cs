namespace OplossingDiOefeningSamurai
{
    public class Samurai
    {
        private readonly IWeapon _weapon;

        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }
    }
}

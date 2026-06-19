namespace Combined 
{
    public class DamageCommand : ICommand
    {
        private IWall _wall;
        private int _damage;

        public DamageCommand(IWall wall, int damage)
        {
            _wall = wall;
            _damage = damage;
        }
        public void Execute()
        {
            _wall.TakeDamage(_damage);
        }

        public void Undo()
        {
            _wall.RestoreHealth(_damage);
        }
    }
}
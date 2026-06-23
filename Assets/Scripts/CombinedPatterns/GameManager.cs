using UnityEngine;

namespace Combined
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Wall _wallReference;
        [SerializeField] private int _damage;
        [SerializeField] private CommandInvoker _commandInvoker;

        private IWall _wall;

        private void Awake()
        {
            _wall = _wallReference;
        }

        public void RegisterHit()
        {
            var command = new DamageCommand(_wall, _damage);
            _commandInvoker.ExecuteCommand(command);
        }

        public void Undo()
        {
            _commandInvoker.Undo();
        }
    }
}
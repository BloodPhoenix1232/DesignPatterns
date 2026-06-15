using System;
using UnityEngine;

namespace Combined
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Wall _wall;
        [SerializeField] private int _damage;
        [SerializeField] private CommandInvoker _commandInvoker;

        public static GameManager Instance { get; private set; }

        void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
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
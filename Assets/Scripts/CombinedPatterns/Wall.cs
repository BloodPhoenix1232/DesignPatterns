using System;
using UnityEngine;

namespace Combined 
{
    public class Wall : MonoBehaviour
    {
        [SerializeField] private int _health;

        public event Action<int> OnHealthChange;

        public int Health
        {
            get => _health;

            private set
            {
                _health = value;
                OnHealthChange?.Invoke(value);
            }
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;

            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }

        public void RestoreHealth(int amount)
        {
            Health += amount;
        }
    }
}
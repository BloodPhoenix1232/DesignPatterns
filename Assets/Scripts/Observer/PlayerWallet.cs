using System;
using UnityEngine;

public class PlayerWallet : MonoBehaviour, IWallet
{
    public event Action<int> OnCoinChanged;

    private int _coins;


    public int Coins
    {
        get => _coins;

        private set
        {
            _coins = value;
            OnCoinChanged?.Invoke(_coins);
        }
    }

    public void AddCoins(int amount)
    {
        Coins += amount;
    }

    public void SpendCoins(int amount)
    {
        Coins = Mathf.Max(0, Coins - amount);
    }
}

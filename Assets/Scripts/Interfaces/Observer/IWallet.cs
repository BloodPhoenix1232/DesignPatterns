using System;
public interface IWallet
{
    event Action<int> OnCoinChanged;
    int Coins { get; }
}

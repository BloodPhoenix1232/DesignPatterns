using TMPro;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] private PlayerWallet _walletReference;
    private IWallet _playerCoins;

    [SerializeField] private TextMeshProUGUI _coinText;

    private void Awake()
    {
        _playerCoins = _walletReference;
    }
    private void OnEnable()
    {
        _playerCoins.OnCoinChanged += UpdateCoinDisplay;
        UpdateCoinDisplay(_playerCoins.Coins);
    }

    private void OnDisable()
    {
        _playerCoins.OnCoinChanged -= UpdateCoinDisplay;
    }

    private void UpdateCoinDisplay(int currentCoins)
    {
        _coinText.text = $"Coins: {currentCoins}";
    }
}

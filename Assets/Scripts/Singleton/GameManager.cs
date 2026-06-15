using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _score;
    [SerializeField] private PlayerWallet _wallet;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        _wallet.OnCoinChanged += OnCoinChanged;
    }
    private void OnCoinChanged(int coins)
    {
        _score += coins;
        Debug.Log($"Score: {_score}");
    }

    private void OnDestroy()
    {
        _wallet.OnCoinChanged -= OnCoinChanged;
    }
}

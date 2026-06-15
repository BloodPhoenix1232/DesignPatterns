using TMPro;
using UnityEngine;

namespace Combined 
{
    public class WallDisplay : MonoBehaviour
    {
        [SerializeField] private Wall _wallReference;
        [SerializeField] private TextMeshProUGUI _healthText;

        private void OnEnable()
        {
            _wallReference.OnHealthChange += UpdateHealthDisplay;
            UpdateHealthDisplay(_wallReference.Health);
        }

        private void OnDisable()
        {
            _wallReference.OnHealthChange -= UpdateHealthDisplay;
        }

        private void UpdateHealthDisplay(int currentHealth)
        {
            _healthText.text = $"Current health: {currentHealth}";
        }
    }
}
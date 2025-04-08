using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private uint[] _prices;
    [SerializeField] private TextMeshProUGUI _rules;

    public uint[] Prices => _prices;

    private static Shop s_instance;
    public static Shop Instance => s_instance;

    private void Awake()
    {
        lock (new object())
        {
            if (s_instance)
                Destroy(gameObject);

            s_instance = this;
        }
    }

    private void Start() => UpdateDisplay();

    public void UpdateDisplay() => _rules.text = $"Rules:\nClick on space to increase score\nPress the 'B' key to buy bonus click ({_prices[0]}$)";
}

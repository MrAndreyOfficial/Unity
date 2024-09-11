using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShopButtonText : MonoBehaviour
{
    [SerializeField] private uint _price;
    [SerializeField] private string _text;

    public uint Price => _price;

    private TextMeshProUGUI _shopButtonText;

    private void Awake()
    {
        _shopButtonText = GetComponent<TextMeshProUGUI>();

        UpdateDisplay();
    }

    public void MultiplyPriceBy(uint count = 4)
    {
        _price *= count;

        UpdateDisplay();
    }

    private void UpdateDisplay() => _shopButtonText.text = $"{_text} - {_price}$";
}

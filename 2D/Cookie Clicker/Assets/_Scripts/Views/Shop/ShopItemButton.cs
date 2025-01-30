using System;
using TMPro;
using UnityEngine;

public abstract class ShopItemButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;

    [SerializeField] private string _displayText;
    [SerializeField] private uint _price;

    protected uint Price => _price;

    public event Action Clicked;

    private void Awake() => UpdateDisplay();

    private void OnMouseDown() => Clicked?.Invoke();

    protected void UpdateDisplay() => _textMesh.text = $"{_displayText} - {_price}$";
    protected void MultiplyPrice(uint multiplier = 2) => _price *= multiplier;
    
    public abstract void BuyBonus();
}

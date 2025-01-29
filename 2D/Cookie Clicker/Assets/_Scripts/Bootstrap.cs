using UnityEngine;

public sealed class Bootstrap : MonoBehaviour
{
    [SerializeField] private Cookie _cookie;

    [Header("Views")]
    [SerializeField] private ScoreView _scoreView;
    [SerializeField] private ShopView _shopView;

    [Header("Buttons")]
    [SerializeField] private ShopButton _shopButton;
    [SerializeField] private BonusClickButton _bonusClickButton;

    private void OnEnable()
    {
        _bonusClickButton.Clicked += _bonusClickButton.BuyBonusClick;
        _bonusClickButton.Clicked += _scoreView.UpdateText;

        _cookie.Clicked += DataContainer.ScoreData.Increase;
        _cookie.Clicked += _scoreView.UpdateText;

        _shopButton.onClick.AddListener(_shopView.gameObject.Toogle);
    }

    private void OnDisable()
    {
        _bonusClickButton.Clicked -= _bonusClickButton.BuyBonusClick;
        _bonusClickButton.Clicked -= _scoreView.UpdateText;

        _cookie.Clicked -= DataContainer.ScoreData.Increase;
        _cookie.Clicked -= _scoreView.UpdateText;
    }
}

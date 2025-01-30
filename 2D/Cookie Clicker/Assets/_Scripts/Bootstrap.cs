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
    [SerializeField] private AutoClickButton _autoClickButton;

    private void OnEnable()
    {
        _bonusClickButton.Clicked += _bonusClickButton.BuyBonus;
        _bonusClickButton.Clicked += _scoreView.UpdateText;

        _autoClickButton.Clicked += _autoClickButton.BuyBonus;
        _autoClickButton.Clicked += _scoreView.UpdateText;

        _cookie.Clicked += DataContainer.Instance.ScoreData.Increase;
        _cookie.Clicked += _scoreView.UpdateText;

        _shopButton.onClick.AddListener(_shopView.gameObject.Toogle);

        StartCoroutine(DataContainer.Instance.AutoClickData.Start());
    }

    private void OnDisable()
    {
        _bonusClickButton.Clicked -= _bonusClickButton.BuyBonus;
        _bonusClickButton.Clicked -= _scoreView.UpdateText;

        _autoClickButton.Clicked -= _autoClickButton.BuyBonus;
        _autoClickButton.Clicked -= _scoreView.UpdateText;

        _cookie.Clicked -= DataContainer.Instance.ScoreData.Increase;
        _cookie.Clicked -= _scoreView.UpdateText;
    }
}

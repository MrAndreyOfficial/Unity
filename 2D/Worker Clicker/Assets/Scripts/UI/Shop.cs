using UnityEngine;
using Worker.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopButtonText _buyBonusClickText;

    private void Awake()
    {
        gameObject.Hide();
    }

    public void Toogle()
    {
        gameObject.Toogle();
    }

    public void BuyBonusClick()
    {
        var bonusClickPrice = _buyBonusClickText.Price;

        if (Bootstrap.GameData.ScoreData.Count >= bonusClickPrice)
        {
            Bootstrap.GameData.BonusData.IncreaseBonusClickByOne();
            Bootstrap.GameData.ScoreData.Decrease(bonusClickPrice);

            _buyBonusClickText.MultiplyPriceBy();

            FindObjectOfType<ScoreText>(true).UpdateDisplay();
        }
    }
}

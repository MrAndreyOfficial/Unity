using UnityEngine;
using Worker.Auto;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopButtonText _buyBonusClickText;
    [SerializeField] private ShopButtonText _hireWorkerText;

    private void Awake() => gameObject.Hide();

    public void Toogle() => gameObject.Toogle();

    public void BuyBonusClick()
    {
        var bonusClickPrice = _buyBonusClickText.Price;

        if (Bootstrap.GameData.ScoreData.Count >= bonusClickPrice)
        {
            Bootstrap.GameData.BonusData.IncreaseBonusClickByOne();
            Bootstrap.GameData.ScoreData.Decrease(bonusClickPrice);

            _buyBonusClickText.MultiplyPriceBy();

            Bootstrap.ScoreText.UpdateDisplay();
        }
    }

    public void HireWorker()
    {
        var hireWorkerPrice = _hireWorkerText.Price;

        if (Bootstrap.GameData.ScoreData.Count >= hireWorkerPrice)
        {
            Bootstrap.GameData.ScoreData.Decrease(hireWorkerPrice);

            _hireWorkerText.MultiplyPriceBy(2);

            AutoWorker.IncreaseBy();

            Bootstrap.ScoreText.UpdateDisplay();
        }
    }
}

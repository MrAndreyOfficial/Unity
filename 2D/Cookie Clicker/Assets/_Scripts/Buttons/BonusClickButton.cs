public sealed class BonusClickButton : ShopItemButton
{
    public override void BuyBonus()
    {
        if (DataContainer.Instance.ScoreData.Score >= Price)
        {
            DataContainer.Instance.BonusData.IncreaseClick();
            DataContainer.Instance.ScoreData.Decrease(Price);

            MultiplyPrice();
            UpdateDisplay();
        }
    }
}

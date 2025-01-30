public sealed class AutoClickButton : ShopItemButton
{
    public override void BuyBonus()
    {
        if (DataContainer.Instance.ScoreData.Score >= Price)
        {
            DataContainer.Instance.AutoClickData.Increase();
            DataContainer.Instance.ScoreData.Decrease(Price);

            MultiplyPrice();
            UpdateDisplay();
        }
    }
}

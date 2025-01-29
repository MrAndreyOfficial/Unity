public class BonusClickButton : ShopItemButton
{
    public void BuyBonusClick()
    {
        if (DataContainer.ScoreData.Score >= Price)
        {
            DataContainer.BonusData.IncreaseClick();
            DataContainer.ScoreData.Decrease(Price);

            MultiplyPrice();
            UpdateDisplay();
        }
    }
}

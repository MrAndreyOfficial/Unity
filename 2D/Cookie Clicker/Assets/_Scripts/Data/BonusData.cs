public sealed class BonusData
{
    private uint _bonusClick = 1;

    public uint BonusClick => _bonusClick;

    public void IncreaseClick() => _bonusClick++;
}

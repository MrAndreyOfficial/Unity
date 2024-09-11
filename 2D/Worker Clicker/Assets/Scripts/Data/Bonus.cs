public class Bonus
{
    private uint _bonusClick = 1;

    public uint BonusClick => _bonusClick;

    public void IncreaseBonusClickByOne() => _bonusClick += 1;
}

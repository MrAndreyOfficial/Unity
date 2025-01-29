public sealed class BonusData
{
    private uint _bonusClick = 1;
    private static BonusData s_instance;

    public uint BonusClick => _bonusClick;
    public static BonusData Instance => s_instance;

    public void IncreaseClick() => _bonusClick++;

    public static BonusData GetInstance()
    {
        lock (new object())
        {
            s_instance ??= new BonusData();

            return s_instance;
        }
    }
}

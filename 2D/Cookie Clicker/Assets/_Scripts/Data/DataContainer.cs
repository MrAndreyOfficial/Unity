public sealed class DataContainer
{
    private static DataContainer s_instance;

    public readonly ScoreData ScoreData = new ScoreData();
    public readonly BonusData BonusData = new BonusData();
    public readonly AutoClickData AutoClickData = new AutoClickData();

    private DataContainer()
    {
    }

    public static DataContainer Instance
    {
        get
        {
            lock (new object())
            {
                s_instance ??= new DataContainer();

                return s_instance;
            }
        }
    }
}

using System;

public sealed class ScoreData
{
    private uint _score;
    private static ScoreData s_instance;

    public uint Score => _score;
    public static ScoreData Instance => s_instance;

    public void Decrease(uint count)
    {
        if (count > _score)
            throw new ArgumentOutOfRangeException(nameof(count), $"Count is greater than score");

        _score -= count;
    }

    public void Increase() => _score += DataContainer.BonusData.BonusClick;

    public static ScoreData GetInstance()
    {
        lock (new object())
        {
            s_instance ??= new ScoreData();

            return s_instance;
        }
    }
}

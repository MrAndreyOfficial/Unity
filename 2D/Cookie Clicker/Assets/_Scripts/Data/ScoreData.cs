using System;

public sealed class ScoreData
{
    private uint _score;

    public uint Score => _score;

    public void Decrease(uint count)
    {
        if (count > _score)
            throw new ArgumentOutOfRangeException(nameof(count), $"Count is greater than score");

        _score -= count;
    }

    public void Increase() => _score += DataContainer.Instance.BonusData.BonusClick;

    public void AutoIncrease() => _score += DataContainer.Instance.AutoClickData.Clicks;
}

using System;

public class Score
{
    private uint _count;

    public uint Count => _count;

    public void Increase(uint count = 1)
    {
        if (count < 1)
            throw new ArgumentOutOfRangeException(nameof(count), "Count is less than 1");

        _count += count;
    }

    public void Decrease(uint count)
    {
        if (count <= 0)
            throw new ArgumentOutOfRangeException(nameof(count), "Count is less than 1");

        _count -= count;
    }
}

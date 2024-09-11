using System;

namespace Worker.Data
{
    public class Score
    {
        private uint _count;

        public uint Count => _count;

        public void Increase(uint count = 1)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must not be less than 1");

            _count += count;
        }

        public void Decrease(uint count = 1)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must not be less than 1");

            _count -= count;
        }
    }
}

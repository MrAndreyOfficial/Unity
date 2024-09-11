using System;

namespace Worker.Data
{
    [Serializable]
    public class GameData
    {
        public readonly Score ScoreData = new Score();
        public readonly Bonus BonusData = new Bonus();
    }
}

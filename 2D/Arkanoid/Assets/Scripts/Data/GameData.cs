public class GameData
{
    private uint _score;

    public uint Score => _score;

    public static readonly GameData Instance = new GameData();

    private GameData() { }

    public void IncreaseScoreByOne() => _score++;
    public void SetScoreToZero() => _score = 0;
}

public static class ScoreData
{
    private static uint s_score;

    public static uint Score => s_score;

    public static void IncreaseByOne() => s_score++;
    public static void SetZero() => s_score = 0;
}

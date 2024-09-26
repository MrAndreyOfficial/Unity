public class GameOverPanel : Panel
{
    private static GameOverPanel s_instance;

    public static GameOverPanel Instance => s_instance;

    private void Awake()
    {
        if (s_instance != null)
            Destroy(gameObject);

        s_instance = this;

        Hide();
    }
}

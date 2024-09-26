public class WonPanel : Panel
{
    private static WonPanel s_instance;

    public static WonPanel Instance => s_instance;

    private void Awake()
    {
        if (s_instance != null)
            Destroy(gameObject);

        s_instance = this;

        Hide();
    }
}

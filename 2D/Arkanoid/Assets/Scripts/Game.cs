using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game
{
    public static void Reset()
    {
        Start();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void Stop() => Time.timeScale = 0;

    private static void Start() => Time.timeScale = 1;
}

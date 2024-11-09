using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScreen : MonoBehaviour
{
    private static NextLevelScreen s_instance;

    public static NextLevelScreen Instance => s_instance;

    private void Awake()
    {
        var locker = new object();

        lock (locker)
        {
            if (s_instance == null)
                s_instance = this;
        }

        gameObject.Hide();
    }

    public void MoveToNextLevel()
    {
        var sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

        if (sceneBuildIndex < SceneManager.sceneCountInBuildSettings - 1)
            SceneManager.LoadScene(sceneBuildIndex + 1);
    }

    public void Show() => gameObject.Show();
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    private static GameOverScreen s_instance;

    public static GameOverScreen Instance => s_instance;

    private void Awake()
    {
        if (s_instance != null)
            Destroy(gameObject);

        s_instance = this;

        gameObject.Hide();
    }

    public void ResetGame()
    {
        Time.timeScale = 1;

        ScoreData.SetZero();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Show() => gameObject.Show();
}

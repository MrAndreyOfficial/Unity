using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    private static GameOverPanel s_instance;

    public static GameOverPanel Instance => s_instance;

    private void Awake()
    {
        lock (new object())
        {
            if (s_instance != null)
                Destroy(gameObject);

            s_instance = this;

            gameObject.Hide();

            DontDestroyOnLoad(gameObject);
        }
    }

    public async void ResetGame()
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;

        await SceneManager.LoadSceneAsync(sceneIndex);
    }
}

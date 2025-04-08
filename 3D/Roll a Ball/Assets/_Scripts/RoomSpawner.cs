using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField] private Room[] _rooms;

    private static uint s_currentRoom;

    private static RoomSpawner s_instance;

    public static RoomSpawner Instance => s_instance;

    private void Awake()
    {
        lock (new object())
        {
            Time.timeScale = 1f;

            if (s_instance != null)
                Destroy(gameObject);

            s_instance = this;

            Instantiate(_rooms[s_currentRoom], transform.position, transform.rotation);

            DontDestroyOnLoad(gameObject);
        }
    }

    public async Task GoToNextRoom()
    {
        if (s_currentRoom < _rooms.Length - 1)
        {
            s_currentRoom++;

            var sceneIndex = SceneManager.GetActiveScene().buildIndex;

            await SceneManager.LoadSceneAsync(sceneIndex);
        }
    }
}

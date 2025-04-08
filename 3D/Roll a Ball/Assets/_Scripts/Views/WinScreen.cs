using UnityEngine;

public class WinScreen : MonoBehaviour
{
    private static WinScreen s_instance;

    public static WinScreen Instance => s_instance;

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

    public async void GoToNextRoom() => await RoomSpawner.Instance.GoToNextRoom();
}

using UnityEngine;
using Worker.Data;

public class Bootstrap : MonoBehaviour
{
    private static GameData s_gameData;

    public static GameData GameData => s_gameData;

    private void Awake()
    {
        s_gameData = new GameData();
    }
}

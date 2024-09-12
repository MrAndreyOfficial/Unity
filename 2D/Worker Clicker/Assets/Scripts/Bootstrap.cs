using UnityEngine;
using Worker.Auto;
using Worker.Data;
using Worker.UI;

public class Bootstrap : MonoBehaviour
{
    private static GameData s_gameData;
    private static ScoreText s_scoreText;

    public static GameData GameData => s_gameData;
    public static ScoreText ScoreText => s_scoreText;

    private void Awake()
    {
        s_gameData = new GameData();

        s_scoreText = FindObjectOfType<ScoreText>(true);
        s_scoreText.UpdateDisplay();

        StartCoroutine(AutoWorker.IncreaseScore());
    }
}

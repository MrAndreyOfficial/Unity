using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreView : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;

    private static ScoreView s_instance;

    public static ScoreView Instance => s_instance;

    private void Awake()
    {
        if (s_instance != null)
            Destroy(gameObject);

        _scoreText = GetComponent<TextMeshProUGUI>();

        s_instance = this;
    }

    public void UpdateDisplay() => _scoreText.text = GameData.Instance.Score.ToString();
}

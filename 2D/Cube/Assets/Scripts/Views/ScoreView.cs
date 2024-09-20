using UnityEngine;
using TMPro;

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

        s_instance = this;

        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDisplay() => _scoreText.text = ScoreData.Score.ToString();
}

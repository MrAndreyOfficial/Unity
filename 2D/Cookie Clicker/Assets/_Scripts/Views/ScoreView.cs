using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public sealed class ScoreView : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;

    private void Awake() => _scoreText = GetComponent<TextMeshProUGUI>();

    public void UpdateText() => _scoreText.text = $"{DataContainer.ScoreData.Score}";
}

using TMPro;
using UnityEngine;

namespace Worker.UI
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreText : MonoBehaviour
    {
        private TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        public void Increase()
        {
            Bootstrap.GameData.ScoreData.Increase(Bootstrap.GameData.BonusData.BonusClick);

            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            _scoreText.text = Bootstrap.GameData.ScoreData.Count.ToString();
        }
    }
}

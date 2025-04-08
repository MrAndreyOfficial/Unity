using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreView : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private static Score s_score;
    private static ScoreView s_instance;

    public static Score Score => s_score;
    public static ScoreView Instance => s_instance;

    private void Awake()
    {
        lock (new object())
        {
            if (s_instance)
                Destroy(gameObject);

            s_instance = this;
        }
    }

    private void Start()
    {
        s_score = new Score();

        _text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDisplay() => _text.text = s_score.Count.ToString();
}

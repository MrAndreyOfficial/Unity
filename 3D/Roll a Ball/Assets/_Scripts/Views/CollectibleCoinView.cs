using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CollectibleCoinView : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private int _howMuchcollect;
    public int HowMuchCollect => _howMuchcollect;

    private static CollectibleCoinView s_instance;
    public static CollectibleCoinView Instance => s_instance;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();

        lock (new object())
        {
            if (s_instance != null)
                Destroy(gameObject);

            s_instance = this;

            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _howMuchcollect = FindObjectsByType<Coin>(FindObjectsSortMode.None).Length;

        UpdateDisplay();
    }

    public void UpdateDisplay() => _text.text = $"Collect coins: {_howMuchcollect}";

    public void DecreaseHowMuchCollect() => _howMuchcollect--;
}

using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class BonusClickView : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private static BonusClick s_bonusClick;
    private static BonusClickView s_instance;

    public static BonusClick BonusClick => s_bonusClick;
    public static BonusClickView Instance => s_instance;

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
        s_bonusClick = new BonusClick();

        _text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDisplay() => _text.text = $"Bonus Clicks: {s_bonusClick.Count}";
}

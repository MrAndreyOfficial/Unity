using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Button[] _resetButtons;

    private void OnEnable()
    {
        GameData.Instance.SetScoreToZero();

        foreach (var resetButton in _resetButtons)
            resetButton.onClick.AddListener(Game.Reset);
    }
}

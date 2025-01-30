using System.Collections;
using UnityEngine;

public sealed class AutoClickData
{
    private uint _clicks;

    private const float AutoClickTimeInSecs = 1f;

    public uint Clicks => _clicks;

    public void Increase() => _clicks++;

    public IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(AutoClickTimeInSecs);

            DataContainer.Instance.ScoreData.AutoIncrease();

            Object.FindFirstObjectByType<ScoreView>().UpdateText();
        }
    }
}

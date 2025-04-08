using UnityEngine;

public class Clicker : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScoreView.Score.Increase(BonusClickView.BonusClick.Count);
            ScoreView.Instance.UpdateDisplay();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            uint price = Shop.Instance.Prices[0];

            if (ScoreView.Score.Count >= price)
            {
                ScoreView.Score.Decrease(price);
                ScoreView.Instance.UpdateDisplay();

                BonusClickView.BonusClick.IncreaseByOne();
                BonusClickView.Instance.UpdateDisplay();

                Shop.Instance.Prices[0] *= 2;
                Shop.Instance.UpdateDisplay();
            }
        }
    }
}

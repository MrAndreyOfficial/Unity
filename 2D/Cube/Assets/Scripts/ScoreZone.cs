using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            ScoreData.IncreaseByOne();
            ScoreView.Instance.UpdateDisplay();
        }
    }
}

using UnityEngine;

public class Brick : MonoBehaviour
{
    public static int Count { get; private set; }

    private void Awake() => Count = FindObjectsOfType<Brick>().Length;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Ball>())
        {
            GameData.Instance.IncreaseScoreByOne();
            ScoreView.Instance.UpdateDisplay();

            Count--;

            if (Count <= 0)
            {
                Game.Stop();

                WonPanel.Instance.Show();
            }

            Destroy(gameObject);
        }
    }
}

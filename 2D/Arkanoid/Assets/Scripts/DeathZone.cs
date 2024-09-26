using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ball>())
        {
            Game.Stop();

            GameOverPanel.Instance.Show();

            Destroy(collision.gameObject);
        }
    }
}

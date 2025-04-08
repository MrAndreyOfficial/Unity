using UnityEngine;

public class DangerWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            GameOverPanel.Instance.gameObject.Show();

            Destroy(collision.gameObject);
        }
    }
}

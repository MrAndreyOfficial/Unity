using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            CollectibleCoinView.Instance.DecreaseHowMuchCollect();
            CollectibleCoinView.Instance.UpdateDisplay();

            if (CollectibleCoinView.Instance.HowMuchCollect <= 0)
            {
                Time.timeScale = 0;

                WinScreen.Instance.gameObject.Show();
            }

            Destroy(gameObject);
        }
    }
}

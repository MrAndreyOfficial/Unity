using UnityEngine;
using Worker.UI;

[RequireComponent(typeof(AudioSource))]
public class ClickButton : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (FindObjectOfType<Shop>(true).gameObject.activeSelf == false)
        {
            _audioSource.Play();

            FindObjectOfType<ScoreText>(true).Increase();
        }
    }
}

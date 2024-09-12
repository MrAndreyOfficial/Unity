using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ClickButton : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake() => _audioSource = GetComponent<AudioSource>();

    private void OnMouseDown()
    {
        if (FindObjectOfType<Shop>(true).gameObject.activeSelf == false)
        {
            _audioSource.Play();

            Bootstrap.ScoreText.Increase();
            Bootstrap.ScoreText.UpdateDisplay();
        }
    }
}

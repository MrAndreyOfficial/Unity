using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    [SerializeField, Range(0, byte.MaxValue)] private float _speedMovement;

    private Rigidbody2D _rigidbody2D;
    private AudioSource _audioSource;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();

        BounceToRandomPosition();
    }

    private void BounceToRandomPosition()
    {
        var positionX = Random.Range(0, 2) == 0 ? 1 : -1;
        var positionY = Random.Range(0, 2) == 0 ? 1 : -1;

        var direction = new Vector2(positionX, positionY);

        _rigidbody2D.velocity = direction * _speedMovement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Brick>())
            _audioSource.Play();
    }
}

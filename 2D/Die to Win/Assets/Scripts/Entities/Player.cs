using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speedMovement;

    private Rigidbody2D _rigidbody2D;
    private Transform _transform;

    private bool _canJump;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

        Move();
    }

    private void Jump()
    {
        if (_canJump)
        {
            _rigidbody2D.velocity += Vector2.up * _jumpForce;
            _canJump = !_canJump;
        }
    }

    private void Move()
    {
        var horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
            _transform.Translate(_speedMovement * horizontalInput * Time.deltaTime * Vector2.right);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _canJump = true;

        if (collision.collider.GetComponent<Spike>())
        {
            NextLevelScreen.Instance.Show();

            Destroy(gameObject);
        }
    }
}

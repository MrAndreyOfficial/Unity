using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField, Range(0, byte.MaxValue)] private float _speedMovement;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal") * _speedMovement;

        if (horizontalInput != 0)
            _transform.Translate(horizontalInput * Time.deltaTime * Vector2.right);
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _transform;
    private Camera _camera;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _camera = Camera.main;
    }

    private void Update()
    {
        var mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        var position = new Vector3(_transform.position.x, mousePosition.y, _transform.position.z);

        _transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Collider2D>())
        {
            GameOverScreen.Instance.Show();

            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}

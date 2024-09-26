using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Boundries : MonoBehaviour
{
    private Vector2 _bounds;

    private Transform _transform;
    private SpriteRenderer _spriteRenderer;

    private float _objectWidth;
    private float _objectHeight;

    private void Awake()
    {
        _bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _objectWidth = _spriteRenderer.size.x;
        _objectHeight = _spriteRenderer.size.y;
    }

    private void LateUpdate()
    {
        var viewPosition = _transform.position;

        viewPosition.x = Mathf.Clamp(viewPosition.x, -_bounds.x + _objectWidth, _bounds.x - _objectWidth);

        _transform.position = viewPosition;
    }
}

using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Boundaries : MonoBehaviour
{
    private Transform _transform;
    private SpriteRenderer _spriteRenderer;

    private Vector2 _screenBounds;

    private float _objectWidth;
    private float _objectHeight;

    private void Awake()
    {
        var camera = Camera.main;
        var screenSize = new Vector3(Screen.width, Screen.height, camera.transform.position.z);

        _screenBounds = Camera.main.ScreenToWorldPoint(screenSize);

        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _objectWidth = _spriteRenderer.bounds.size.x / 2;
        _objectHeight = _spriteRenderer.bounds.size.y / 2;
    }

    private void LateUpdate()
    {
        var currentPosition = transform.position;

        currentPosition.x = Mathf.Clamp(currentPosition.x, -_screenBounds.x + _objectWidth, _screenBounds.x - _objectWidth);
        currentPosition.y = Mathf.Clamp(currentPosition.y, -_screenBounds.y + _objectHeight, _screenBounds.y - _objectHeight);

        _transform.position = currentPosition;
    }
}

using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField, Range(0, byte.MaxValue)] private float _speed;

    private Transform _transform;

    private void Awake() => _transform = GetComponent<Transform>();

    private void Update() => _transform.Translate(_speed * Time.deltaTime * Vector2.left);
}

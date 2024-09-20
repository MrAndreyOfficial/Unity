using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField, Range(0, byte.MaxValue)] private float _timeSpawnInSecs;
    [SerializeField] private ObstacleMovement _obstacle;

    private Transform _transform;

    private const float MinPositionY = -0.5f;
    private const float MaxPositionY = 0.5f;

    private void Awake()
    {
        _transform = GetComponent<Transform>();

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(_timeSpawnInSecs);

            var position = new Vector2(_transform.position.x, Random.Range(MinPositionY, MaxPositionY));

            Instantiate(_obstacle, position, _transform.rotation);
        }
    }
}

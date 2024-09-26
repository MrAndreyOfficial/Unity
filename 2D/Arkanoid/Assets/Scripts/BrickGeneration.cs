using UnityEngine;

public class BrickGeneration : MonoBehaviour
{
    [SerializeField] private Vector2 _size;
    [SerializeField] private Vector2 _offsetBrick;

    [SerializeField] private Brick[] _bricks;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();

        Generate(_size, _offsetBrick);
    }

    private void Generate(Vector2 size, Vector2 offsetBrick)
    {
        var sizeX = size.x;
        var sizeY = size.y;

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                var brick = _bricks[Random.Range(0, _bricks.Length)];

                var newBrick = Instantiate(brick, _transform);

                var position = new Vector3((float)((sizeX - 1) * 0.5f - x) * offsetBrick.x, y * offsetBrick.y, _transform.position.z);

                newBrick.transform.position = _transform.position + position;
            }
        }
    }
}

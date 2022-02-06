using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float speed;

    private int numberArray;
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[numberArray].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, points[numberArray].position) < 0.2f)
        {
            if (numberArray > 0)
            {
                numberArray = 0;
            }
            else
            {
                numberArray = 1;
            }
        }
    }
}

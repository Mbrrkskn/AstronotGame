using UnityEngine;

public class Dusman : MonoBehaviour
{
    public float velocity = 0.5f;
    public float moveDistance = 2f;

    private Vector3 startPosition;
    private bool isMoveRight = true;
    private bool triggered = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isMoveRight)
        {
            if (transform.position.x <= startPosition.x + moveDistance)
                transform.Translate(Vector3.right * velocity * Time.deltaTime);
            else
                isMoveRight = false;
        }
        else
        {
            if (transform.position.x >= startPosition.x - moveDistance)
                transform.Translate(Vector3.left * velocity * Time.deltaTime);
            else
                isMoveRight = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            GameManager.instance.LoseGame();
        }
    }
}

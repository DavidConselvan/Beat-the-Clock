using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    public float speed = 2f;
    public float changeDirectionTime = 2f;

    private Vector2 movementDirection;
    private float timer;
    private Rigidbody2D rb;
    public AudioSource source;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        ChooseNewDirection();
    }

    void FixedUpdate()
    {
        if (GameController.GameOver) return;

        rb.linearVelocity = movementDirection * speed;

        timer += Time.fixedDeltaTime;
        if (timer >= changeDirectionTime)
        {
            ChooseNewDirection();
            timer = 0f;
        }
    }

    void ChooseNewDirection()
    {
        float angle = Random.Range(0f, 360f);
        float rad = angle * Mathf.Deg2Rad;
        movementDirection = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)).normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ChooseNewDirection();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            if (source != null)
            {
                source.Play();
            }

            GameController.TriggerGameOver();
        }
    }
}


using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float speed = 5f;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(horizontalInput, 0f);

        transform.Translate(movement * speed * Time.deltaTime);

        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }

        animator.SetBool("isWalking", horizontalInput != 0);
    }
}

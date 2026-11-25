using UnityEngine;

public class CambiarAnimacionDistancia : MonoBehaviour
{
    public float distanciaActivacion = 5f;

    private Vector3 firstPosition;
    private Animator animator;
    private bool animacionCambiada = false;

    void Start()
    {
        firstPosition = transform.position;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distanceThisFrame =
            Vector3.Distance(firstPosition, transform.position);

        if (distanceThisFrame >= distanciaActivacion && !animacionCambiada)
        {
            animator.SetTrigger("changeAnimation");
            animacionCambiada = true;
            animator.SetBool("isWalking", false);
        }
    }
}

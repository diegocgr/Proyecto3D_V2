using UnityEngine;

public class ClickToAnimate : MonoBehaviour
{
    private Animator animator;
    private bool abierto = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (!abierto)
        {
            animator.Play("Caixaobrir");
        }
        else
        {
            animator.Play("Caixatancar");
        }

        abierto = !abierto; // Alternar estado
    }
}
using UnityEngine;

public class ClickToAnimate : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        
        animator.Play("Caixaobrir");
        
    }
}
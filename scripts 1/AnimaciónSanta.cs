using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaciónSanta : MonoBehaviour
{
    [SerializeField] Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            // Activa el trigger para cambiar a la animación "CalabazaColision".
            animator.SetTrigger("ColisionTrigger");
        }
    }
}

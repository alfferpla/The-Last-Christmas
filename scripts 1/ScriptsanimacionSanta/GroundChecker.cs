using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool CalabazaColision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si la colisión está en el layer 10
        if (collision.gameObject.layer == 10)
        {
            // Desactiva la animación 1 y activa la animación 2
            animator.SetBool("CalabazaColision", false);
            animator.SetBool("Animacion2", true);
            CalabazaColision = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool CalabazaColision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si la colisi�n est� en el layer 10
        if (collision.gameObject.layer == 10)
        {
            // Desactiva la animaci�n 1 y activa la animaci�n 2
            animator.SetBool("CalabazaColision", false);
            animator.SetBool("Animacion2", true);
            CalabazaColision = false;
        }
    }
}

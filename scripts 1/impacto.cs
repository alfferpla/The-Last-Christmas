using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impacto : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool CalabazaColision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("CalabazaColision", true);
        CalabazaColision = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        animator.SetBool("CalabazaColision", false);
        CalabazaColision = false;
    }
}

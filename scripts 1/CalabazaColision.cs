using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalabazaColision : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            Debug.Log("5 Segundos");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 13) 
        {
            //FindObjectOfType<Shoot>().shootRate = 5;
            //La línea de arriba hace lo mismo que la de abajo

            collision.gameObject.GetComponent<Shoot>().shootRate = 5;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirClabazaColision : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Vector3 beamVelocity;
    [SerializeField] float timeDestruction;


    void Start()
    {
        rb2d.velocity = beamVelocity;
        Destroy(gameObject, timeDestruction);

        //esta es la manera más sencilla de destruir la bala, a los dos segundos la bala se destruirá

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 10 || collision.gameObject.layer == 12)
        {
             //Destroy(collision.gameObject); se destruiría el objeto con el que se choque
            Destroy(gameObject);   //se destruye el objeto al collisionar
        }
       
    }
}

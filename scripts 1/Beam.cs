using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Vector3 beamVelocity;

    
    //Para limitar las balas
    [SerializeField] float timeToDestroyBeam;

    /*[SerializeField] float valueToDestryBeam;
    La otra manera de destruir las balas es hacer esta variable de clase serializada y poder modificarlo desde unity*/

    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = beamVelocity;
       
        //esta es la manera más sencilla de destruir la bala, a los dos segundos la bala se destruirá

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
            
        {
            ScoreManager.scoreManagerSingleton.AddScore();
        }
        
    }

    private void Update()
    {
       

        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
            //este metodo es para que las balas se destruyan cuando x llegue a la posicion 11,
            //gameObject así en minúscula hace referencia al objeto que tiene dentro 

        }
    }
}
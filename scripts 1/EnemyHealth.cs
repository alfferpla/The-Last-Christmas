using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int life;
    [SerializeField] GameObject explosion;
    [SerializeField] int points;
    public static int balasImpactadas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if(collision.gameObject.layer == 8)
      
        Destroy(collision.gameObject);

        balasImpactadas++;
        ScoreManager.scoreManagerSingleton.RefreshAccuracy();
        life = life - 1;

        if (life <= 0) 
        {
            Instantiate(explosion, transform.position, Quaternion.identity);

            ScoreManager.scoreManagerSingleton.AddScore();
           
         
            Destroy(gameObject);
        }

        
    }


}

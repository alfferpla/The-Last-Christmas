using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 enemyVelocity;
    // Start is called before the first frame update
    void Update()
    {
        rb.velocity = enemyVelocity;
    }

   
}

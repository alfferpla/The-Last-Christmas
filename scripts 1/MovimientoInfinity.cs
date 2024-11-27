using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoInfinity : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Vector2 boxVelocity;
    [SerializeField] float timeDestruction;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = boxVelocity;
        Destroy(gameObject, timeDestruction);
    }
}

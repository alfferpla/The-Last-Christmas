using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontroler : MonoBehaviour
{
    public static shipcontroler shipcontrolerSingleton;

    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float shipVelocity;
    [SerializeField] float x;
    [SerializeField] float y;

    public bool CalabazaColision1;
    [SerializeField] Animator animatorSanta;

    private void Start()
    {
        animatorSanta = GetComponent<Animator>();
    }




    void Awake()
    {
        shipcontrolerSingleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(x, y) * shipVelocity;
    }
    public void StopShipController() 
    {
        shipVelocity = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            animatorSanta.SetTrigger("CalabazaColision1");

        }
    }
    
}


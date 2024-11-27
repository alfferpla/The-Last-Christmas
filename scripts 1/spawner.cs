using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject Gift;
    [SerializeField] float counterTime;
    [SerializeField] float timeTocreate;
    [SerializeField] float x;
    [SerializeField] float y;
    public Rigidbody2D rb;
    [SerializeField] float gravityScale;




    // Update is called once per frame
    void Update()
    {

        counterTime = counterTime + Time.deltaTime;

        if (counterTime >= timeTocreate)

        {
            counterTime = 1;
            Instantiate(Gift, transform.position, Quaternion.identity);
        }
       
        if (transform.position.y == 4)
        {
            gravityScale = 2;
        }

        else if (transform.position.y == -4)
        {
            gravityScale = -2;
        }

    }   
}



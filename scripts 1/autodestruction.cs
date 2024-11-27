using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodestruction : MonoBehaviour
{
    [SerializeField] float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

   
}

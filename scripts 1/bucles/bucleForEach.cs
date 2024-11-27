using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucleForEach : MonoBehaviour
{
    [SerializeField] float[] notas;
    // Start is called before the first frame update
    void Start()
    {
        foreach (float note in notas) 
        {
            if (note > 5) 
            {
                Debug.Log("Aprobado");

            }
            else 
            {
                Debug.Log("Suspenso");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

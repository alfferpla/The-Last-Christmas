using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejemplobucleWhile : MonoBehaviour
{
    [SerializeField] float [] notas;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < notas.Length) 
        {
            if (notas[i] >= 5) 
            {
                Debug.Log("Aprobado");
            }
            else 
            {
                Debug.Log("Suspenso");

            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

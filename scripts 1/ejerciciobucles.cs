using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciobucles : MonoBehaviour
{
    
    [SerializeField] float[] notas;

    // Start is called before the first frame update
    void Start()
    {
       
        for(int i=0; i<notas.Length; i++) 
        {
            if(notas[i] >= 5) 
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

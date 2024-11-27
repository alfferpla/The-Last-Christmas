using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    [SerializeField] float[] notas = new float[5];
    // Start is called before the first frame update
    void Start()
    {
        float suma = (notas[0] + notas[1] + notas[2] + notas[3] + notas[4]);
        Debug.Log(suma/notas.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

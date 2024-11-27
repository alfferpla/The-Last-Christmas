using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle : MonoBehaviour
{
    [SerializeField] float[] notes;
    [SerializeField] float[] resultado;
    // Start is called before the first frame update
    void Start()
    {
        float suma = 0;

        for(int i=0; i < notes.Length; i++) 
        {
            suma = suma + notes[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

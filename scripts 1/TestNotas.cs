using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNotas : MonoBehaviour
{
    [SerializeField] bool esOyente;
    [SerializeField][Range(0,10)] float nota;
    /*ejercicio que guarde en una variable de clase la nota de un alumno, si la nota es del 5 al 6, devolver por consola
     * aprobado, bien, notable, sobresaliente, ademas la calse tendra una variable, si es oyente el mensaje
     * dirá que la nota no está registrada*/
    // Start is called before the first frame update
    void Start()
    {
        if (esOyente == true)
            Debug.Log("La nota anterior no queda registrada");


        if (nota >= 5 && nota < 6)
        {
            Debug.Log("Aprobado");
        }
            
        else if (nota >= 6 && nota < 7)
        {
            Debug.Log("Bien");
        }
           
        else if (nota >=7 && nota < 9)
        {
            Debug.Log("Notable");
        }
           
        else if (nota >= 9)
        {
            Debug.Log("Sobresaliente");
        }
        else
        {
            Debug.Log("Suspenso");
        }    


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

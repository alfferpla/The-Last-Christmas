using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
    public static CuentaAtras cuentaAtrasSingleton;


    private void Awake()
    {
        cuentaAtrasSingleton = this;
    }


}

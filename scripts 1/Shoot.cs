using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject Gift;
    [SerializeField] int beamCount;
    public int shootRate;
    public static int shootCounter;

    // Update is called once per frame
    void Update()
    {
        beamCount = beamCount++;

        if (Input.GetKey(KeyCode.Space))
      
        /*el beamcount y el if. sirve para limitar las balas a una cada 20 frames, de ahí el %20  
       en general sirve para limitar cualquier evento para que no se compruebe 60 veces por segundo*/
        {
            Instantiate(Gift, transform.position, Quaternion.identity);
            //cada vez que disparo, en el source suena clip
            shootCounter++;
        }
    }
    private void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 20;
    }
}




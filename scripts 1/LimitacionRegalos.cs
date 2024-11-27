using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitacionRegalos : MonoBehaviour
{
    [SerializeField] GameObject Gift;
    private float lastShotTime; // Variable para realizar un seguimiento del tiempo del último disparo.

    // Configura la velocidad de disparo deseada (1 regalo por segundo).
    public float shootingCooldown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Verifica si ha pasado el tiempo de enfriamiento.
            if (Time.time - lastShotTime >= shootingCooldown)
            {
                // Puedes disparar porque ha pasado el tiempo de enfriamiento.
                Instantiate(Gift, transform.position, Quaternion.identity);
                lastShotTime = Time.time; // Actualiza el tiempo del último disparo.
            }
        }
    }

    private void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 20;
        lastShotTime = -shootingCooldown; // Inicializa el tiempo del último disparo para permitir el primer disparo.
    }
}

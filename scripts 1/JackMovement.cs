using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackMovement : MonoBehaviour
{
    [SerializeField] float radius = 2.0f;  // Radio del c�rculo
    [SerializeField] float speed = 1.0f;  // Velocidad de rotaci�n en radianes por segundo
    private float angle = 0.0f;  // �ngulo actual

    // Define la posici�n inicial
    private Vector3 initialPosition = new Vector3(5.6f, 1.7f, -1.5f);

    void Start()
    {
        // Establece la posici�n inicial
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Calcula la nueva posici�n en el c�rculo
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        // Aplica la posici�n al objeto
        transform.position = new Vector3(x + initialPosition.x, y + initialPosition.y, initialPosition.z);

        // Incrementa el �ngulo en funci�n de la velocidad y el tiempo
        angle += speed * Time.deltaTime;
    }
}

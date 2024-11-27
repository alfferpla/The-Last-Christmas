using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackMovement : MonoBehaviour
{
    [SerializeField] float radius = 2.0f;  // Radio del círculo
    [SerializeField] float speed = 1.0f;  // Velocidad de rotación en radianes por segundo
    private float angle = 0.0f;  // Ángulo actual

    // Define la posición inicial
    private Vector3 initialPosition = new Vector3(5.6f, 1.7f, -1.5f);

    void Start()
    {
        // Establece la posición inicial
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Calcula la nueva posición en el círculo
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        // Aplica la posición al objeto
        transform.position = new Vector3(x + initialPosition.x, y + initialPosition.y, initialPosition.z);

        // Incrementa el ángulo en función de la velocidad y el tiempo
        angle += speed * Time.deltaTime;
    }
}

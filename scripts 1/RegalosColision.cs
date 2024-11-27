using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegalosColision : MonoBehaviour
{
    [SerializeField] AudioClip clipRegaloEntregado;
    [SerializeField] float timeDestruction;

    private void Start()
    {
        Destroy(gameObject, timeDestruction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            AudioManager.audioManagerSingleton.PlayFXSound(clipRegaloEntregado);
            Destroy(gameObject);
            
        }
    }
}

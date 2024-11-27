using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] float scrollVelocity;
    [SerializeField] Renderer rendererM;
    public bool stopScroll;

    //mueve el offset de manera automatica
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rendererM.material.mainTextureOffset = new Vector2(((Time.time) * scrollVelocity) % 1, 0);
    }
}
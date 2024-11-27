using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerJose : MonoBehaviour
{
    [SerializeField] GameObject[] enemy;
    [SerializeField] float counterTime;
    [SerializeField] float TimeToCreate;
    
    // Update is called once per frame
    void Update()
    {
        counterTime = counterTime + Time.deltaTime;

        if (counterTime >= TimeToCreate)
        {
            counterTime = 0;
            int randomNumber = Random.Range(0, enemy.Length);
            Instantiate(enemy[randomNumber], transform.position, Quaternion.identity);

        }
    }
}

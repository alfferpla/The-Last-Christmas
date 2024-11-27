using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFinished : MonoBehaviour
{
    public static TimeFinished timeFinished;

    public float Time;


    private void Awake()
    {
        timeFinished = this;
    }

    public void StopGame()
    {
        if(Time <= 0)
        {

        }
    }
}

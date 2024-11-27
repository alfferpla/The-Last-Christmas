using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatsManager
{

    public static float GetBulletImpactedPercent(int balasLanzadas, int balasImpactadas)
    {
       return ((float)balasImpactadas/(float)balasLanzadas) *100;
    }
}

   





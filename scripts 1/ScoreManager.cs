using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManagerSingleton;

    [SerializeField] int score;
    [SerializeField] Text scoreText, timerText;
    /*[SerializeField] Text accuracyPercent;*/

    public float countdownTime;


    private void Awake()
    {
        scoreManagerSingleton = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Gifts Delivered: " + score;

        RecordManager.recordManagerSingleton.CheckRecord(score);


    }

    private void Update()
    {
        ChronoMethod();
    }

    void ChronoMethod()
    {
        countdownTime -= Time.deltaTime;
        if (countdownTime <= 0)
        {
            countdownTime = 0;
                
            GameOverManager.gameOverManager.InitializeGameOver(); 
        }

        timerText.text = "Timer: " + countdownTime.ToString("F0"); 
    }

    public void RefreshAccuracy() 
    {
        /*accuracyPercent.text = "Accuracy: " + StatsManager.GetBulletImpactedPercent(Shoot.shootCounter, EnemyHealth.balasImpactadas) + " %"; */
    }
}

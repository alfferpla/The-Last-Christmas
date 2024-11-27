using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager gameOverManager;

    [SerializeField] Scroll[] scrollArray;
    [SerializeField] shipcontroler stopSanta;
    [SerializeField] Animator animatorSanta;
    [SerializeField] LimitacionRegalos stopRegalos;
    [SerializeField] SpawnerJose stopCalabazas;
    [SerializeField] GameObject gameOverPanel;



    private void Awake()
    {
        gameOverManager = this;
    }

    public void InitializeGameOver()
    {
        for (int i = 0; i < scrollArray.Length; i++)
        {
            scrollArray[i].stopScroll = true;
        }

       

        stopRegalos.enabled = false;

        stopCalabazas.enabled = false;

        stopSanta.enabled = false;

        animatorSanta.SetBool("SantaVolar", true);

        ScoreManager.scoreManagerSingleton.enabled = false;
        gameOverPanel.SetActive(true);
    }
    

}

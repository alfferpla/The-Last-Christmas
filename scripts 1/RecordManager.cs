using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManager : MonoBehaviour
{
   
    public static RecordManager recordManagerSingleton;
    [SerializeField] Text recordText;



    // Update is called once per frame
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Record") == false)
        {
            PlayerPrefs.SetInt("Record", 0);
        }

        recordManagerSingleton = this; 
    }

    private void Start()
    {
        ShowInitialRecord();
    }

    public void CheckRecord(int n)
    {
        if (n > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", n);
            recordText.text = "Record: " + n;
        }
    }

    void ShowInitialRecord()
    {
        recordText.text = "Record: " + PlayerPrefs.GetInt("Record");
    }

}


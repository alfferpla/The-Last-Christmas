using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioManagerSingleton;

    [SerializeField] AudioSource source;

    private void Awake()
    {
        audioManagerSingleton = this;
    }

    public void PlayFXSound(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}

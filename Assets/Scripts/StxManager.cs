using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StxManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip Click;

    public AudioSource SeringaSound;

    public AudioClip Seringa;

    public static StxManager sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}

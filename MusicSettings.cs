﻿
using UnityEngine;

public class MusicSettings : MonoBehaviour
{

    private AudioSource audioSrc;
    private float musicVolume = 1f;

    public void SetVolume (float vol)
    {
        musicVolume = vol;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
    }
}

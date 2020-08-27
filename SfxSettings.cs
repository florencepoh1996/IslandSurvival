
using UnityEngine;

public class SfxSettings : MonoBehaviour
{

    private AudioSource audioSrc;
    private float SfxVolume = 1f;

    public void SFXVolume(float vol)
    {
        SfxVolume = vol;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = SfxVolume;
    }
}

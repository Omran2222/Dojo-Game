using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip playerJump, coinCollect, winSound,playerShoot;
   
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayPlayerJump()
    {
        audioSource.PlayOneShot(playerJump);
    }

    public void PlayCoinCollect()
    {
        audioSource.PlayOneShot(coinCollect);
    }

    public void PlayWindSound()
    {
        audioSource.PlayOneShot(winSound);
    }

    public void PlayPlayerShoot()
    {
        audioSource.PlayOneShot(playerShoot);
    }
}

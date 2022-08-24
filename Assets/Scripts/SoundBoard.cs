using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBoard : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip Sound1;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MusicPlayer();
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            audioSource.PlayOneShot(Sound1);
        }
    }

    private void MusicPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            audioSource.Stop();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.Pause();
        }
        
    }
}

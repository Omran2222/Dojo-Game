using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSomthing : MonoBehaviour
{
    [SerializeField]private GameObject MyPrefab;
    [SerializeField]private AudioClip MySound;

    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            InvokeRepeating("Spawn",0.1f,0.1f);
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            CancelInvoke("Spawn");
        }
    }

    private void Spawn()
    {
        Instantiate(MyPrefab,transform.position, transform.rotation);

        audioSource.pitch = Random.Range(1,1.1f);
        audioSource.PlayOneShot(MySound);
    }
}

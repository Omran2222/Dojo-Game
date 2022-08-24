using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrets : MonoBehaviour
{
    [SerializeField]private Transform bulletSpawnPoint;
    [SerializeField]private GameObject Enemybullet;
    private Transform player;
    private bool detected = false;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        transform.LookAt(player); // استخدمنا الدالة  الموجوده داخل LookAt 

        DetectingPlayer();
    }

    private void DetectingPlayer()
    {
        float PlayerDistance = Vector3.Distance(player.transform.position, transform.position);

        if(PlayerDistance <= 10 && detected == false)
        {
            detected = true;
            InvokeRepeating("Shooting",1,1);
        }
        else if(PlayerDistance > 10)
        {
            detected = false;
            CancelInvoke("Shooting");
        }
        
    }
    
    private void Shooting()
    {
       Instantiate(Enemybullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);     
    }
   
}

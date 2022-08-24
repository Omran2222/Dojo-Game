using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField]private float bulletSpeed;
    [SerializeField]private float bulletLifeSpawn;
    private Rigidbody RB;
    private PlayerHealth playerHealthScript;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(transform.forward * bulletSpeed);
        Invoke("Delete", bulletLifeSpawn);
    }

    private void Delete()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerHealthScript = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealthScript.HealthAmount--;
            
            Destroy(gameObject);
        }
    }

}

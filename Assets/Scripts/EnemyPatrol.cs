using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private Transform TargetPos;

    private PlayerHealth playerHealth;
    private Rigidbody EnemyRB;
   // private GameObject player;
    private float speed = 4f;

    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        EnemyRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
      Vector3 EnemyMove = Vector3.MoveTowards(transform.position,TargetPos.position, speed * Time.fixedDeltaTime);

      EnemyRB.MovePosition(EnemyMove);
      transform.LookAt(TargetPos);

    }

    private void OnCollitionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth.HealthAmount -= 0.1f;
            playerHealth.enemy = collision.gameObject.transform;
            
               
        }
            
            

        
    }

}

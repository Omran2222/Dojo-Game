using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private float BulletSpeed;
    [SerializeField]private float BulletLifeSpan;//مدة بقاء الرصاصة عائمة فالهواء او الفضاء 
    private Rigidbody RB;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(transform.forward * BulletSpeed);
        
       



        Invoke("Delete", BulletLifeSpan);//حذف الرصاصه بعد انقضاءالمدة المقدره لها فالهواء
    }

    private void Delete()
    {
        Destroy(gameObject);
    }

  

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            
            Destroy(gameObject);
        }
    }

   
}

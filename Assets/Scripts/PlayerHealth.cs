using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    

    //[SerializeField]private TextMeshProUGUI HealthCounter;
    [SerializeField]private Image HealthBar;
    public float HealthAmount;
    [SerializeField]private Transform SpawnPoint;
     private Rigidbody RgB;
    private PlayerMovment PlayerMovmentScript;
    public Transform enemy;
    

    private void Start()
    {
        RgB = GetComponent<Rigidbody>();
        
        
        PlayerMovmentScript = GetComponent<PlayerMovment>();
        
    }
    
    
    private void Update()
    {
        if (HealthAmount <= 0)
        {
            Die();
        } 

       // HealthCounter.text = ("" + Health);
       HealthBar.fillAmount = HealthAmount;
    
       
    }

    private void Die()
    {
        transform.position = SpawnPoint.position;
        HealthAmount = 1f;
        
    }

    private void Damage()
    {
        PlayerMovmentScript.enabled = false;

        RgB.AddForce(transform.up * 150);

        if(transform.position.x < enemy.position.x)
        {
            transform.Translate(Vector3.right * -500);
        }
        else
        {
            transform.Translate(Vector3.right * 450);
        }
            Invoke("MoveAgain",1);
    }

    private void MoveAgain()
    {
        PlayerMovmentScript.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HealthAmount-= 0.1f;
            enemy = collision.gameObject.transform;
            
               
        }
            
            

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    // يستخدم هذا السكربت كرصيد لزيادة دم اللاعب   
    
    private PlayerHealth PlayerHealthScript;
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            PlayerHealthScript = Other.gameObject.GetComponent<PlayerHealth>();
            PlayerHealthScript.HealthAmount++;

            Destroy(gameObject);
        }
    }
    
}

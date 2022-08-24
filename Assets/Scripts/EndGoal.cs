using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : MonoBehaviour
{
    private void OnTriggerEnter(Collider EndG)
    {
        
       if (EndG.gameObject.CompareTag("Player"))
       {
         
            
            Destroy(gameObject);
             
            Debug.Log("You are Winner");
       }
           
       

        
    }
}

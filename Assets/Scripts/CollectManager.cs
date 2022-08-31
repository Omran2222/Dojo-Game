using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectManager : MonoBehaviour
{
   [SerializeField]private TextMeshProUGUI CubeCounter;
   [SerializeField]private TextMeshProUGUI SphereCounter;
   [SerializeField]private TextMeshProUGUI CapsuleCounter;
    private int CubeCollected = 0;
    private int SphereCollected = 0;
    private int CapsuleCollected = 0;
    private PlayerMovment PlayerMovmentScript;


    void Start()
    {
        PlayerMovmentScript = GetComponent<PlayerMovment>();
    }

    private void Update()
    {
        CubeCounter.text = ("" + CubeCollected);
        SphereCounter.text = ("" + SphereCollected);
        CapsuleCounter.text = ("" + CapsuleCollected);
    }
   
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            CubeCollected++;
            
            Destroy(other.gameObject);
        }

         if (other.gameObject.CompareTag("Sphere"))
        {
            SphereCollected++;
            
            Destroy(other.gameObject);
        }

         if (other.gameObject.CompareTag("Capsule"))
        {
            CapsuleCollected++;
            
            Destroy(other.gameObject);
        }
    }
}

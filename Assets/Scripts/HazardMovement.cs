using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HazardMovement : MonoBehaviour
{
    [SerializeField] private float HzSpeed = 0.5f;
    
    [SerializeField] private Vector3 StartPoint;
    [SerializeField] private Vector3 EndPoint;

    private void Start()
    {
        StartPoint = transform.position;
        EndPoint = new Vector3(StartPoint.x, StartPoint.y+2f, StartPoint.z);
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(StartPoint, EndPoint, Mathf.PingPong(Time.time*HzSpeed,2f));
    }
    
   /* private void OnCollisionEnter(Collision other)
    {   
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("OnCollision is now active");
        }
    }*/

     private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("OnTrigger is now active");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public SoundManager Sm;
   
    [SerializeField] private float Speed;
    private Rigidbody RgB;

    //private float Facing;


    private void Start()
    {
        RgB = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        var Horizontal = Input.GetAxis("Horizontal")*Speed;
        var Vertical = Input.GetAxis("Vertical")*Speed;

        Vector3 Movement = new Vector3(Horizontal,0,Vertical);

        RgB.velocity = new Vector3(Movement.x, RgB.velocity.y ,Movement.z);
        

        RgB.AddForce(Physics.gravity * 1f, ForceMode.Acceleration);

        


        Jump();
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
           
            RgB.AddForce(transform.up * 300);

            Sm.PlayPlayerJump();
        }
        
    }


 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    
   // [SerializeField] private float JumpForce;
    //[SerializeField] private Transform groundCheck;
   //[SerializeField] private LayerMask groundLayer;
    private Rigidbody rb;
    private bool CanJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      /*if(Input.GetButtonDown("Jump") && CanJump == true)
        {
            CanJump = true;
            rb.AddForce(transform.up * 500);

            Sm.PlayPlayerJump();  
        }*/
        //Jump();

    }
    /*private void Jump()
    {
        if(Input.GetButtonDown("Jump") && CanJump == true)
        {
            CanJump = false;
            rb.AddForce(transform.up * JumpForce);

            Sm.PlayPlayerJump();
        }
    }*/
}

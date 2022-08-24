using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPcontroller : MonoBehaviour
{
    
    public float Speed;
    public float RotationSpeed;
    public float JumpSpeed;

    private CharacterController PlayerController;
    private float Yspeed;
    public float MoveSpeed;
    public float RunSpeed;
    private float OriginalStepOffset;

   private void Start()
    {
        PlayerController = GetComponent<CharacterController>();
       
        OriginalStepOffset = PlayerController.stepOffset;
    }

   private void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        float CurrentSpeed = (Input.GetKey(KeyCode.LeftShift)) ? RunSpeed : MoveSpeed;
        Vector3 MovementDirection = new Vector3(HorizontalInput, 0, VerticalInput);
        float magnitude = Mathf.Clamp01(MovementDirection.magnitude) * CurrentSpeed;
        MovementDirection.Normalize();

        Yspeed += Physics.gravity.y * Time.deltaTime;

        if (PlayerController.isGrounded)
        {
            PlayerController.stepOffset = OriginalStepOffset;
            Yspeed = -0.5f;

            if (Input.GetButtonDown("Jump"))
            {
                Yspeed = JumpSpeed;
            }
        }
        else
        {
            PlayerController.stepOffset = 0;
        }

        Vector3 velocity = MovementDirection * magnitude;
        velocity.y = Yspeed;

        PlayerController.Move(velocity * Time.deltaTime);

        if (MovementDirection != Vector3.zero)
        {
            Quaternion ToRotation = Quaternion.LookRotation(MovementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, ToRotation, RotationSpeed * Time.deltaTime);
        }
    }
}

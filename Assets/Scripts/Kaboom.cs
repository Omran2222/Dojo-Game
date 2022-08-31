using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaboom : MonoBehaviour
{
    public float explosionRadius; // is how far out our explosion will reach. It can be small or large, depending on what you trying to simulate.
    public float explosionForce; // is how much force will be used to send nearby objects flying away.
    public float UpForce; //is the same as explosionForce, but focused only on sending objects upward.
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
       RB = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Invoke("Explosion",0);
        }
    }

    private void Explosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position,explosionRadius);

        foreach(Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(explosionForce,transform.position, explosionRadius, UpForce, ForceMode.Impulse);
            }
        }
    }
}

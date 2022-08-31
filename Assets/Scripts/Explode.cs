using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField]private GameObject Player;
    [SerializeField]private GameObject ExplosionParticles;
    public float Dist;
    [SerializeField]private float MinDistance;
    
    
    void Start()
    {
        
        StartCoroutine("DestroyParticles");
    }
    
    // Update is called once per frame
    void Update()
    {
        Dist = Vector3.Distance(ExplosionParticles.transform.position,Player.transform.position);
        
        if(Input.GetButtonDown("Fire1"))
        {
            ExplodeEffect();
        }
    }

    public void ExplodeEffect()
    {
        GameObject Prefap = Instantiate(ExplosionParticles, transform.position, transform.rotation);
    }

    IEnumerator DestroyParticles()
    {
        if(MinDistance >= Dist)
        {
            yield return new WaitForSeconds(8);
            Destroy(gameObject);
        }
       
    }
}

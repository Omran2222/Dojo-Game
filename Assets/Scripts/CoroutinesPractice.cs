using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoroutinesPractice : MonoBehaviour
{
    [SerializeField]private GameObject Plan;
    [SerializeField]private TextMeshProUGUI Words;
    [SerializeField]private Rigidbody RB;

    void Start()
    {
        StartCoroutine("MySequence");
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StopCoroutine("MySequence");
            Destroy(Words.gameObject);
        }
    }
    private IEnumerator MySequence()
    {
        /*
        yield return new WaitForSeconds(2);
        Words.text = ("Hello 2 Second have passed");
        yield return new WaitForSeconds(3);
        Words.text = ("Do you want to see this Cube jump?");
        Destroy(Words.gameObject);
        RB.AddForce(Vector3.up * 800);
        RB.AddForce(Vector3.forward * 600);
        yield return new WaitForSeconds(2);
        Destroy(Plan);
        */

        while(true)
        {
            yield return new WaitForSeconds(2);
            Words.text = ("Hello!");
            yield return new WaitForSeconds(2);
            Words.text = ("Goodbay");
        }
    }
}

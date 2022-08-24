using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]private Text GameClock;
    [SerializeField]private int TimeLeft;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CountDown",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        GameClock.text = ("" + TimeLeft); 

         if(TimeLeft < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }  
    }

    private void CountDown()
    {
        TimeLeft--;
    }
}

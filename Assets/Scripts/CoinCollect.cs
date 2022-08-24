using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI CoinCounter;
    private int CoinsCollected = 0;
    private PlayerMovment PlayerMovmentScript;


    void Start()
    {
        PlayerMovmentScript = GetComponent<PlayerMovment>();
    }

    private void Update()
    {
        CoinCounter.text = ("" + CoinsCollected);
    }
   
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinsCollected++;
            PlayerMovmentScript.Sm.PlayCoinCollect();
            Destroy(other.gameObject);
        }

        /*if (other.gameObject.CompareTag("Winner") && Coins >= 20)
        {
            Debug.Log("Winner");
            PlayerMovmentScript.Sm.PlayCoinCollect();
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
        }

        if (other.gameObject.CompareTag("Winner") && Coins < 20)
        {
            Debug.Log("Collect more coins");

        }*/

    }
}

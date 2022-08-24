using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    [SerializeField]private string GameScene;
    public void PlayGame()
    {
        SceneManager.LoadScene(GameScene);
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}

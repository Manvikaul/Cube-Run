using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float delay=1f;
    public GameObject levelCompUI;
    public GameObject crash;

    public void LevelComplete()
    {
        levelCompUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded==false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            crash.SetActive(true);
            Invoke("Restart", delay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float delay=1f;

    public void EndGame()
    {
        if(gameEnded==false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", delay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

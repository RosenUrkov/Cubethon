using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int RESTART_DELAY = 1;

    public GameObject completeLevelUI;
    private bool gameHasEnded = false;

    public void EndGame()
    {
        if(gameHasEnded)
        {
            return;
        }

        gameHasEnded = true;
        Invoke("Restart", RESTART_DELAY);
    }

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//This reloads the game scene.
public class GameOver : MonoBehaviour
{
    public void RestartGame()
    {
        if (GlobalVariables.points > GlobalVariables.highScore)
        {
            GlobalVariables.highScore = GlobalVariables.points;
            PlayerPrefs.SetInt("HighScore", GlobalVariables.highScore);
        }

        GlobalVariables.points = 0;
        SceneManager.LoadScene(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public static SimulationManager Instance;  
    public ScoreController score;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        StartGame();

    }

    public void StartGame()
    {
       
    }

    public void PauseGame()
    {

    }

    public void ResumeGame()
    {

    }

    public void FinishGame()
    {

    }

    public void ResetGame()
    {

    }
}

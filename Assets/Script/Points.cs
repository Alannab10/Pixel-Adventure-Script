using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private int score;  

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.CompareTag("Player"))
        {        
            if (SimulationManager.Instance != null && SimulationManager.Instance.score != null)
            {             
                SimulationManager.Instance.score.AddScore(score);         
                gameObject.SetActive(false);  
            }
        }
    }
}

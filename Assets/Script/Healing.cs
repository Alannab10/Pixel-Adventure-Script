using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private float cure;  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Life>())
        {
            collision.gameObject.GetComponent<Life>().Treatment(cure);
            gameObject.SetActive(false); 
        }
    }
}

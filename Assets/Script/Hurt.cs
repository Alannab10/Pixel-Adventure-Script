using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    [SerializeField] private float hurt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Life>())
        {
            collision.gameObject.GetComponent<Life>().Stroke(hurt);
        }
    }
}

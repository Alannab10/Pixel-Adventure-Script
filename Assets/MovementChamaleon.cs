using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChamaleon : MonoBehaviour
{
    Animator anima;
    Rigidbody2D rigid;

    public Collider2D objective;
    public float speed;
    public Transform center;
    public Vector2 size;
    public LayerMask layers;

    public float distance;
    private bool isDead;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();

        layers = LayerMask.GetMask("Player");
    }

    private void FixedUpdate()
    {
        objective = Physics2D.OverlapBox(center.position, size, 0, layers);
        anima.SetBool("PlayerDetected", objective);
        if (objective != null)
        {
            distance = Vector2.Distance(transform.position, objective.transform.position);
            anima.SetFloat("Distance", distance);
        }
    }

    private void MoveTowardsPlayer()
    {
        if (objective != null)
        {         
            direction = (objective.transform.position - transform.position).normalized; 
       
            rigid.velocity = new Vector2(direction.x * speed, rigid.velocity.y);  
         
            anima.SetBool("IsRunning", true);
        }
        else
        {
            
            rigid.velocity = new Vector2(0, rigid.velocity.y);
            anima.SetBool("IsRunning", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(center.position, size);
    }
}

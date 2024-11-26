using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovementPoints : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();
    [SerializeField] float speed;
    private int currentTarget = 0;

    void Start()
    {
        if (points.Count > 0)
        {
            transform.position = points[0].position;
        }
    }

    void Update()
    {
        if (points.Count == 0) return;
        Transform currentTargetTransform = points[currentTarget];       
        transform.position = Vector3.MoveTowards(transform.position, currentTargetTransform.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentTargetTransform.position) < 0.1f)
        {
            currentTarget++;
            if (currentTarget >= points.Count)
            {
                currentTarget = 0; 
            }
        }
    }
}

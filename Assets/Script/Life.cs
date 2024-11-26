using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Life : MonoBehaviour
{
    public delegate void LifeChangedDelegate(float newLife);
    public LifeChangedDelegate HarmReceived;
    public LifeChangedDelegate TreatmentReceived;

    [SerializeField] private float life;
    public float maximumLife;
    
    private void Start()
    {
        maximumLife = life;
    }

    public void Stroke(float hurt)
    {
        life -= hurt;

        HarmReceived?.Invoke(life);
        if (life <= 0)
        {
            life = 0;
            Destroy(gameObject);
        }     
    }

    public void Treatment(float cure)
    {
        life += cure;
        if (life > maximumLife)
        {
            life = maximumLife;  
        }

        TreatmentReceived?.Invoke(life);
    }
  
}

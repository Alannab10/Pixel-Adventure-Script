using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] Life lifee;
    [SerializeField] Image bar;

    public void Start()
    {
        lifee.HarmReceived += UpdatingLife;
        lifee.TreatmentReceived += UpdatingLife;
    }

    public void UpdatingLife(float newCount)
    {
        bar.fillAmount = (1/lifee.maximumLife) * newCount;
    }
}

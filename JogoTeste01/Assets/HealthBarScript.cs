using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    private HealthScript healthSystem;

    public void Setup(HealthScript healthSystem)
    {
        this.healthSystem = healthSystem;
    }

    private void FixedUpdate()
    {
        transform.Find("Bar").localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
    }
}

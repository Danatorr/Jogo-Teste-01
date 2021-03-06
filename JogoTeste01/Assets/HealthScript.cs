using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private int health;
    private int healthMax;

    public HealthScript(int healthMax)
    {
        this.health = healthMax;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }

    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 0) health = 0;
    }

    public void Heal(int healAmount)
    {
        health += healAmount;

        if (health > healthMax) health = healthMax;
    }
}

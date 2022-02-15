using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public int startAttack;
    public int startDefense;
    public int startAgility;
    public int startLuck;

    public bool isDead = false;

    public void checkHealth()
    {
        if(currentHealth >= maxHealth)
            currentHealth = maxHealth;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
        }
    }

    public virtual void Die()
    {

    }
}

using UnityEngine;

public class playerStats : MonoBehaviour{

public int health;
public int currentHealth {get; private set; }
public Stat attack;
public Stat defense;
public Stat agility;
public Stat damage;

void Awake()
{
    currentHealth = health;
}
public void TakeDamage(int damage)
{
    damage -= defense.GetValue();
    damage = Mathf.Clamp(damage, 0, int.MaxValue);

    currentHealth -= damage;

    if(currentHealth <= 0)
    {
        Die();
    }
}
public virtual void Die()
{

}

}
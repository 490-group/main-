using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    // Start is called before the first frame update
    
    PlayerUI playerUI;

    void Start()
    {

        playerUI = GetComponent<PlayerUI> ();

        maxHealth = 20;
        currentHealth = maxHealth;

        startAttack = 2;
        startDefense = 2;
        startAgility = 2;
        startLuck = 2;

        SetStats();
    }

    // Update is called once per frame
    public override void Die()
    {
        Debug.Log("You Die!");
    }

    void SetStats(){
       playerUI.healthAmount.text = currentHealth.ToString();
       playerUI.attackAmount.text = startAttack.ToString();
       playerUI.defenseAmount.text = startDefense.ToString();
       playerUI.agilityAmount.text = startAgility.ToString();
       playerUI.luckAmount.text = startLuck.ToString();
   }
}

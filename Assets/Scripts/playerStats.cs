using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerStats : CharacterStats
{
    // Start is called before the first frame update
    
    PlayerUI playerUI;
    public GameObject hurtScreen;
    public int levelAmount = 1;
    public static playerStats instance = null;
    public int level = 1;
    //bool temp = false;
    void Start()
    {

        playerUI = GetComponent<PlayerUI> ();

        maxHealth = 20;
        currentHealth = maxHealth;
        Debug.Log(startLevel);
        startAttack = 2;
        startDefense = 2;
        startAgility = 2;
        startLuck = 2;
        startLevel = 1;
      
        
        
        //startLevel += levelAmount;
        SetStats();
        if (instance == null){
            instance = this;
        }
        Debug.Log("level:" + level);
    }
    IEnumerator waiter(){
        yield return new WaitForSeconds(0.1f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        hurtScreen.SetActive(false);
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
       //playerUI.levelAmount.text = startLevel.ToString();
   }
   /*void onCollisionEnter(Collision other){
        if(other.CompareTag("enemy")){
           if (startDefense >= 10){
               currentHealth -= 5;
           }
           if (startDefense < 10){
               currentHealth -= 10;
           }
           //currentHealth -= 10;
           //hurtScreen = GameObject.Find("hurtScreen");
           hurtScreen.SetActive(true);
           StartCoroutine(waiter());
           Destroy (other.gameObject);
           
           if(currentHealth <= 0){
               SceneManager.LoadScene("Death");
           }
           SetStats();   
        }
   }*/
   void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("weapon")){
           startAttack += 10;
           Destroy (other.gameObject);
           SetStats();   
        }
        if(other.CompareTag("armor")){
           startDefense += 10;
           Destroy (other.gameObject);
           SetStats();   
        }
        if(other.CompareTag("footgear")){
           startAgility += 10;
           Destroy (other.gameObject);
           SetStats();   
        }
        if(other.CompareTag("rings")){
           startLuck += 10;
           Destroy (other.gameObject);
           SetStats();   
        }
        if(other.CompareTag("enemy")){
           if (startDefense >= 10){
               currentHealth -= 5;
           }
           if (startDefense < 10){
               currentHealth -= 10;
           }
           //currentHealth -= 10;
           //hurtScreen = GameObject.Find("hurtScreen");
           hurtScreen.SetActive(true);
           StartCoroutine(waiter());
           Destroy (other.gameObject);
           
           if(currentHealth <= 0){
               SceneManager.LoadScene("Death");
           }
           SetStats(); 
        }
        if(other.CompareTag("boss")){
           startLevel++;
           temp = true;
           Debug.Log(startLevel);
           levelAmount++;
           instance.level++;
           Debug.Log("level:" + level);
           //levelAmount = level;
           //Destroy (other.gameObject);
           SetStats();   
           //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
           int xcount = Random.Range(1, 3);
           Debug.Log("count:" + xcount);
           if(xcount == 1){
           
            SceneManager.LoadScene("Loading2");
           }
           else if(xcount == 2){
            SceneManager.LoadScene("Loading3");
           }
           //}
           //else if(xcount == 2){
           //SceneManager.LoadScene("Loading2");
           //}
           
           
        }
    }

}

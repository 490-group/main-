using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{   
    public Text healthAmount, attackAmount, defenseAmount, agilityAmount, luckAmount, levelAmount;
    public int buildIndex;

    private void Start()
    {
        //buildIndex = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
        //levelText.text = "Level: " + buildIndex.ToString("0");
    }

    public void levelUpdate ()
    {
        Debug.Log("Triggered");
        //levelText.text = "Level: " + buildIndex.ToString("0");
        Debug.Log(SceneManager.GetActiveScene().buildIndex+1);
    }



}

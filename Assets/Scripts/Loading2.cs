using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loading2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(waiter()); 
    }

    IEnumerator waiter(){
        yield return new WaitForSeconds(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        SceneManager.LoadScene("Main2");
        //Debug.Log("level:" + playerStats.instance.level);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

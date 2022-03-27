using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    	//anim.SetBool("isAttacked", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
    		
       		//Attacked();
       
       		
       	}
       	//anim.SetBool("isAttacked", false);
    }

    void Attacked(){
    	//anim.SetBool("isAttacked", true);
    }
}

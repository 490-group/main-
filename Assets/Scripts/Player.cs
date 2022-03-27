using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{

    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    private bool isMoving;
    private Vector3 origPos, targetPos;
    //private float timeToMove = 0.1f;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    //public int health;
    //public int healthcap;
    //public Text healthbox;
    private Animator anim;
    private Vector2 moveDirection;
    public GameObject protag;
    private CharacterStats startAttack;
    //public int startAttack;
    private void Start(){
        boxCollider = GetComponent<BoxCollider2D>();
        
        //healthbox = GetComponent<Text>();
        
        //health = 10;
        //healthcap = 10;
        startAttack = protag.GetComponent<CharacterStats>();
        anim = GetComponent<Animator>();
        //anim.SetBool("isAttacking", false);
    }

    private void Update(){
    	ProcessInputs();


    	


    }

    void FixedUpdate(){
    	move();
    }

    void ProcessInputs(){
    	float moveX = Input.GetAxisRaw("Horizontal");
    	float moveY = Input.GetAxisRaw("Vertical");
    	moveDirection = new Vector2(moveX, moveY);
    	if(Input.GetKeyDown(KeyCode.Space)){
    		
       		Attack();
       
       		
       	}
    }

    void move(){
    	rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    	//resetAttack();
    }
    void Attack(){
    	//anim.SetBool("isAttacking", true);
    	//yield return new WaitForSecondsRealtime(1);
    	//resetAttack();
    	
    }

    void resetAttack(){
    	//anim.SetBool("isAttacking", false);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("boss")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
            
        }
        if(other.CompareTag("item")){
           //startAttack = 10;
           //Debug.Log("Ant Smashed");
            
        }
    }

    void pickupItem(Collider2D other){
        if(other.CompareTag("item")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
            
        }
    }
}

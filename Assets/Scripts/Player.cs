using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour{

    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.1f;

    public int health;
    public int healthcap;
    public Text healthbox;

    private void Start(){
        boxCollider = GetComponent<BoxCollider2D>();
        healthbox = GetComponent<Text>();
        
        health = 10;
        healthcap = 10;
    }

    private void Update(){
    	if (Input.GetKey(KeyCode.W) && !isMoving)
    		StartCoroutine(MovePlayer(Vector3.up));
        if (Input.GetKey(KeyCode.A) && !isMoving)
    		StartCoroutine(MovePlayer(Vector3.left));
        if (Input.GetKey(KeyCode.S) && !isMoving)
    		StartCoroutine(MovePlayer(Vector3.down));
        if (Input.GetKey(KeyCode.D) && !isMoving)
    		StartCoroutine(MovePlayer(Vector3.right));
    }

    private IEnumerator MovePlayer(Vector3 direction){
    	isMoving = true;

    	float elapsedTime = 0;

    	origPos = transform.position;
    	targetPos = origPos + direction;

    	while(elapsedTime < timeToMove){
    		transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
    		elapsedTime += Time.deltaTime;
    		yield return null;
    	}

    	transform.position = targetPos;

    	isMoving = false;
    }
}

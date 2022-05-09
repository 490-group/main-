using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

    public Transform player;

    public float moveSpeed = 0.1f;

    private Rigidbody2D rb;

    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        //still working on the next 2 lines. its supposed to allow for enemy to always be looking at player
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        direction.Normalize();
        movement = direction;

    }

    private void FixedUpdate() {
        moveCharacter(movement);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
           
           
           
             
        }
    }

    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * (moveSpeed/3) * Time.deltaTime));
    }
}
